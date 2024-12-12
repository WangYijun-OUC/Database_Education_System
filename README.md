### 数据库课设

**所需环境**：
- Visual Studio 2019
- MySQL-5.7.38
- Navicat for MySQL 11.1

**安装流程**：

1. 使用 `VisualStudioSetup` 安装 `VS 2019`。
2. 在 `navicat` 文件夹下：
    - 首先安装 `navicat 11`。
    - 接着解压破解机，路径选择安装路径下的 `exe` 文件。
3. 安装 `MySQL5.7.38` 和两个 `msi` 文件，`mysql` 安装参考 [https://blog.csdn.net/nandao158/article/details/128424136](https://blog.csdn.net/nandao158/article/details/128424136)，成功启动 `MySQL` 进程即可。
4. 将 `sql` 导入 `MySQL`：
    - 在 `Navicat` 下新建连接（可不输密码）。
    - 新建 `education_system` 数据库，右键导入 `education_system.sql`。
5. 测试 `VS` 是否能连接数据库：参考教程第四部分 [https://blog.csdn.net/jikenvhai/article/details/127784661](https://blog.csdn.net/jikenvhai/article/details/127784661)。
6. 项目启动主界面为 `Program.cs`，数据库中 `login_info` 表代表用户名和密码，`identify` 中 `t = teacher`，`s = student`，`a = admin`。

**PS**：需要修改请提交 `PR` 。 