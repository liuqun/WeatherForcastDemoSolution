# 测试用数据库

1. book表
```sql
--
-- 表的结构 `book`
--
DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `id` int(11) NOT NULL,
  `isbn_code` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT '',
  `title` varchar(1024) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT '',
  `author` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT '',
  `publisher` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT '',
  `pages` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci ROW_FORMAT=COMPACT;

ALTER TABLE `book`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `book`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
COMMIT;

--
-- 转存表中的数据 `book`
--
INSERT INTO `book` (`isbn_code`, `title`, `author`, `publisher`, `pages`) VALUES ('123-12345678', '书名111', '简介111', '出版社111', '111');
INSERT INTO `book` (`isbn_code`, `title`, `author`, `publisher`, `pages`) VALUES ('223-12345678', '书名222', '简介222', '出版社222', '222');
```

2. 类别category表

```
--
-- 表的结构 `book_category`
--
DROP TABLE IF EXISTS `book_category`;
CREATE TABLE `book_category` (
  `id` int(11) NOT NULL,
  `category_title` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `category_description` varchar(1024) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `parent_id` int(11) DEFAULT '0' COMMENT '所属的上一级图书分类ID号'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

ALTER TABLE `book_category`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `book_category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;
```