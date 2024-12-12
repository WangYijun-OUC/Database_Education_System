/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 80030
Source Host           : localhost:3306
Source Database       : education_system

Target Server Type    : MYSQL
Target Server Version : 80030
File Encoding         : 65001

Date: 2022-11-11 19:07:15
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for course
-- ----------------------------
DROP TABLE IF EXISTS `course`;
CREATE TABLE `course` (
  `Cno` char(4) NOT NULL,
  `Cname` char(20) NOT NULL,
  `Cpno` char(4) DEFAULT NULL,
  `Cpname` char(20) DEFAULT NULL,
  `Ccredit` float DEFAULT NULL,
  `Tname` char(20) DEFAULT NULL,
  PRIMARY KEY (`Cno`),
  KEY `Cpno` (`Cpno`),
  CONSTRAINT `course_ibfk_1` FOREIGN KEY (`Cpno`) REFERENCES `course` (`Cno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- ----------------------------
-- Records of course
-- ----------------------------
INSERT INTO `course` VALUES ('1', '思想道德修养和法律基础', null, null, '3', '董振娟');
INSERT INTO `course` VALUES ('10', '高等数学1', null, null, '6', '张凯');
INSERT INTO `course` VALUES ('11', '高等数学2', '10', '高等数学1', '6', '张凯');
INSERT INTO `course` VALUES ('12', '高级语言程序设计', null, null, '4', '李华');
INSERT INTO `course` VALUES ('13', '面向对象的程序设计', '12', '高级语言程序设计', '4', '徐文华');
INSERT INTO `course` VALUES ('14', '离散数学I', null, null, '4', '王志刚');
INSERT INTO `course` VALUES ('15', '数据结构与算法', '14', '离散数学I', '4', '蒋若冰');
INSERT INTO `course` VALUES ('16', '计算机网络', '15', '数据结构与算法', '4', '洪峰');
INSERT INTO `course` VALUES ('17', '操作系统', '15', '数据结构与算法', '4', '聂捷');
INSERT INTO `course` VALUES ('18', '数据库系统', '15', '数据结构与算法', '4', '刘洁');
INSERT INTO `course` VALUES ('19', '软件工程', '13', '面向对象的程序设计', '3', '高峰');
INSERT INTO `course` VALUES ('2', '中国近现代史纲要', null, null, '3', '王红兵');
INSERT INTO `course` VALUES ('20', '大数据技术原理与应用', '18', '数据库系统', '3', '刘洁');
INSERT INTO `course` VALUES ('21', 'DB_Design', null, null, '2', '王');
INSERT INTO `course` VALUES ('25', '1', null, null, '0.5', '蒋若冰');
INSERT INTO `course` VALUES ('26', '1', null, null, '0.5', '蒋若冰');
INSERT INTO `course` VALUES ('27', '111111', '12', '高级语言程序设计', '2.5', '蒋若冰');
INSERT INTO `course` VALUES ('28', '大学物理1', null, null, '3.5', '王福鹏');
INSERT INTO `course` VALUES ('29', '大学物理2', '28', '大学物理1', '3.5', '王福鹏');
INSERT INTO `course` VALUES ('3', '马克思主义基本原理概论', null, null, '3', '曹');
INSERT INTO `course` VALUES ('30', '大学物理', '36', '大物', '3', '蒋若冰');
INSERT INTO `course` VALUES ('31', '计算机组成原理', null, null, '4', '蒋永国');
INSERT INTO `course` VALUES ('36', '大物', '5', '大学英语1', '2.5', '蒋若冰');
INSERT INTO `course` VALUES ('4', '军事科学概论', null, null, '2', '边秀玉');
INSERT INTO `course` VALUES ('5', '大学英语1', null, null, '2', '无');
INSERT INTO `course` VALUES ('6', '大学英语2', null, null, '2', '无');
INSERT INTO `course` VALUES ('7', '大学英语3', null, null, '2', '杨倩');
INSERT INTO `course` VALUES ('8', '大学英语4', null, null, '2', '高委婉');
INSERT INTO `course` VALUES ('9', '1', '7', '大学英语3', '2', '李波');

-- ----------------------------
-- Table structure for login_info
-- ----------------------------
DROP TABLE IF EXISTS `login_info`;
CREATE TABLE `login_info` (
  `id` char(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `username` char(10) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `password` char(10) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `identity` char(2) DEFAULT NULL,
  `isadmin` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- ----------------------------
-- Records of login_info
-- ----------------------------
INSERT INTO `login_info` VALUES ('1', '1', '1', 't', null);
INSERT INTO `login_info` VALUES ('20020001001', 'wang', '111', 's', '0');
INSERT INTO `login_info` VALUES ('20020001002', 'a', '111', 'a', '1');
INSERT INTO `login_info` VALUES ('20020001003', '666', '111', 's', '0');
INSERT INTO `login_info` VALUES ('20020001004', '111', '222', 's', '0');
INSERT INTO `login_info` VALUES ('20020001091', 'wa', '111', 's', null);
INSERT INTO `login_info` VALUES ('t1', '222', '666', 't', '0');

-- ----------------------------
-- Table structure for sc
-- ----------------------------
DROP TABLE IF EXISTS `sc`;
CREATE TABLE `sc` (
  `Sno` char(11) NOT NULL,
  `Cno` char(4) NOT NULL,
  `Grade` smallint DEFAULT NULL,
  PRIMARY KEY (`Cno`,`Sno`),
  KEY `Sno` (`Sno`),
  CONSTRAINT `sc_ibfk_1` FOREIGN KEY (`Cno`) REFERENCES `course` (`Cno`),
  CONSTRAINT `sc_ibfk_2` FOREIGN KEY (`Sno`) REFERENCES `student` (`Sno`),
  CONSTRAINT `sc_chk_1` CHECK (((`Grade` >= 0) and (`Grade` <= 100)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- ----------------------------
-- Records of sc
-- ----------------------------
INSERT INTO `sc` VALUES ('20020001001', '1', '98');
INSERT INTO `sc` VALUES ('20020001002', '1', '96');
INSERT INTO `sc` VALUES ('20020001010', '1', '89');
INSERT INTO `sc` VALUES ('20020001013', '1', '59');
INSERT INTO `sc` VALUES ('20020001001', '11', '79');
INSERT INTO `sc` VALUES ('20020001001', '13', '49');
INSERT INTO `sc` VALUES ('20020001012', '13', '89');
INSERT INTO `sc` VALUES ('20020001001', '14', '88');
INSERT INTO `sc` VALUES ('20020001004', '15', '75');
INSERT INTO `sc` VALUES ('20020001017', '15', '100');
INSERT INTO `sc` VALUES ('20020001001', '16', '99');
INSERT INTO `sc` VALUES ('20020001001', '17', '99');
INSERT INTO `sc` VALUES ('20020001001', '18', '97');
INSERT INTO `sc` VALUES ('20020001004', '18', null);
INSERT INTO `sc` VALUES ('20020001001', '19', '60');
INSERT INTO `sc` VALUES ('20020001004', '19', null);
INSERT INTO `sc` VALUES ('20020001001', '2', '46');
INSERT INTO `sc` VALUES ('20020001001', '20', '52');
INSERT INTO `sc` VALUES ('20020001004', '20', null);
INSERT INTO `sc` VALUES ('20020001001', '21', '77');
INSERT INTO `sc` VALUES ('20020001004', '21', null);
INSERT INTO `sc` VALUES ('20020001001', '3', '59');
INSERT INTO `sc` VALUES ('20020001002', '3', null);
INSERT INTO `sc` VALUES ('20020001001', '4', '59');
INSERT INTO `sc` VALUES ('20020001001', '5', '20');
INSERT INTO `sc` VALUES ('20020001001', '6', '84');
INSERT INTO `sc` VALUES ('20020001001', '7', '85');
INSERT INTO `sc` VALUES ('20020001001', '8', '80');
INSERT INTO `sc` VALUES ('20020001001', '9', null);

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `Sno` char(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Sname` char(20) DEFAULT NULL,
  `Ssex` char(2) DEFAULT NULL,
  `Sage` smallint DEFAULT NULL,
  `Sdept` char(20) DEFAULT NULL,
  PRIMARY KEY (`Sno`),
  UNIQUE KEY `Sname` (`Sname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('20020001001', '王翔', '男', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001002', '刘晨', '女', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001003', '王敏', '女', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001004', '张慧', '女', '20', '光电科学与工程学院');
INSERT INTO `student` VALUES ('20020001005', '张立', '男', '20', '电子工程学院');
INSERT INTO `student` VALUES ('20020001006', '毕超杰', '男', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001007', '黄舒彬', '女', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001008', '陈浩', '男', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001009', '褚红伟', '男', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001010', '康乐', '男', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001011', '孔东营', '女', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001012', '兰佳', '女', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001013', '崔咏梅', '女', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001014', '李洪超', '男', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001015', '李贡湘', '男', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001016', '江丽莎', '女', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001017', '郭战齐', '女', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001018', '陈慧', '女', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001019', '陈建翔', '男', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001020', '郭群', '女', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001021', '洪博为', '男', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001022', '冯国纲', '女', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001023', '崔世民', '女', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001024', '段未杰', '男', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001025', '郭泓', '女', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001026', '玫兰莎', '女', '19', '电子工程学院');
INSERT INTO `student` VALUES ('20020001027', '王维娜', '女', '21', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001028', '银灰', '男', '20', '计算机科学与技术学院');
INSERT INTO `student` VALUES ('20020001100', '11', '男', '15', '计算机科学与技术学院');

-- ----------------------------
-- Table structure for teacher
-- ----------------------------
DROP TABLE IF EXISTS `teacher`;
CREATE TABLE `teacher` (
  `Tno` char(10) NOT NULL,
  `Tname` char(20) DEFAULT NULL,
  `Cno` char(4) DEFAULT NULL,
  `Tsex` char(4) DEFAULT NULL,
  `Tdept` char(30) DEFAULT NULL,
  `Tage` smallint DEFAULT NULL,
  PRIMARY KEY (`Tno`),
  KEY `Cno` (`Cno`),
  CONSTRAINT `Cno` FOREIGN KEY (`Cno`) REFERENCES `course` (`Cno`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- ----------------------------
-- Records of teacher
-- ----------------------------
INSERT INTO `teacher` VALUES ('1', '1', null, '男', '计算机科学与技术学院', '11');
INSERT INTO `teacher` VALUES ('t1', '蒋若冰', '15', '女', '计算机科学与技术学院', '31');
INSERT INTO `teacher` VALUES ('t2', '蒋永国', '31', '男', '计算机科学与技术学院', '35');
