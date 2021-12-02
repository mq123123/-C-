package com.codeslogan;

import com.codeslogan.mapper.UserMapper;
import com.codeslogan.pojo.User;
import com.codeslogan.service.UserServiceImpl;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.util.unit.DataUnit;

import javax.sql.DataSource;
import java.sql.SQLException;
import java.util.Date;

@SpringBootTest
class HnucisysApplicationTests {

    @Autowired
    UserServiceImpl userService;

    @Autowired
    DataSource dataSource;
    @Test
    void contextLoads() throws SQLException {
        System.out.println(dataSource.getClass());
        System.out.println(dataSource.getConnection());
    }

    @Autowired
    UserMapper userMapper;
    //测试插入sql是否执行成功
    @Test
    void adduser(){
        User user = new User();
        user.setUserId(1007);
        user.setUsername("Test01");
        user.setPassword("123456");
        user.setGrade(3);
        user.setMajor("计算机");
        user.setSex(0);
        user.setQq("1234657");
        user.setIntroduction("asdsad");
        user.setCreatetime(new Date());
        user.setUpdatetime(new Date());
        System.out.println(user);
        userMapper.AddUser(user);
    }
}
