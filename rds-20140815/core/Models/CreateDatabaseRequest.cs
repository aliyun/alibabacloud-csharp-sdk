// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account. You can call the <a href="https://help.aliyun.com/document_detail/610454.html">DescribeAccounts</a> operation to query the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The type of permission granted to the account. If you specify multiple database names, you must specify the same number of permission types in the same order and separate them with commas (,).</para>
        /// <para>Different database engines support different permission types. Valid values:</para>
        /// <remarks>
        /// <para>For more information about account permissions, see <a href="https://help.aliyun.com/document_detail/146395.html">Permission list for ApsaraDB RDS for MySQL and ApsaraDB RDS for MariaDB</a>, <a href="https://help.aliyun.com/document_detail/95692.html">Permission list for ApsaraDB RDS for SQL Server</a>, and <a href="https://help.aliyun.com/document_detail/257684.html">Permission list for ApsaraDB RDS for PostgreSQL</a>.</para>
        /// </remarks>
        /// <details>
        /// <summary>ApsaraDB RDS for MySQL and ApsaraDB RDS for MariaDB</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write</description></item>
        /// <item><description><b>ReadOnly</b>: read-only</description></item>
        /// <item><description><b>DDLOnly</b>: DDL-only</description></item>
        /// <item><description><b>DMLOnly</b>: DML-only</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>ApsaraDB RDS for SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write. This permission corresponds to the <c>db_datawriter</c> and <c>db_datareader</c> database roles in SQL Server.</description></item>
        /// <item><description><b>ReadOnly</b>: read-only. This permission corresponds to the <c>db_datareader</c> database role in SQL Server.</description></item>
        /// <item><description><b>DBOwner</b>: database owner. This permission corresponds to the <c>db_owner</c> database role in SQL Server.<remarks>
        /// <para>For more information about database-level roles, see <a href="https://learn.microsoft.com/en-us/sql/relational-databases/security/authentication-access/database-level-roles?view=sql-server-ver16">Microsoft official documentation</a>.</para>
        /// </remarks>
        /// </details></description></item>
        /// </list>
        /// <details>
        /// <summary>ApsaraDB RDS for PostgreSQL</summary>
        /// 
        /// <para><b>DBOwner</b>: database owner</para>
        /// <remarks>
        /// <para>For more information about fine-grained permission management for accounts, see <a href="https://help.aliyun.com/document_detail/352149.html">Best practices for permission management in ApsaraDB RDS for PostgreSQL</a>.</para>
        /// </remarks>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The character set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL and ApsaraDB RDS for MariaDB: <b>utf8</b>, <b>gbk</b>, <b>latin1</b>, and <b>utf8mb4</b>.</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server: <b>Chinese_PRC_CI_AS</b>, <b>Chinese_PRC_CS_AS</b>, <b>SQL_Latin1_General_CP1_CI_AS</b>, <b>SQL_Latin1_General_CP1_CS_AS</b>, and <b>Chinese_PRC_BIN</b>.</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL: You must configure the character set, collation, and ctype in the <c>character set,&lt;collation&gt;,&lt;ctype&gt;</c> format. Example: <c>UTF8,C,en_US.utf8</c>.<list type="bullet">
        /// <item><description>Valid values for the character set: <b>KOI8U, UTF8, WIN866, WIN874, WIN1250, WIN1251, WIN1252, WIN1253, WIN1254, WIN1255, WIN1256, WIN1257, WIN1258, EUC_CN, EUC_KR, EUC_TW, EUC_JP, EUC_JIS_2004, KOI8R, MULE_INTERNAL, LATIN1, LATIN2, LATIN3, LATIN4, LATIN5, LATIN6, LATIN7, LATIN8, LATIN9, LATIN10, ISO_8859_5, ISO_8859_6, ISO_8859_7, ISO_8859_8, and SQL_ASCII</b>.</description></item>
        /// <item><description>Valid values for <b>collation</b>: You can execute the <c>SELECT DISTINCT collname FROM pg_collation;</c> statement to query the values. If you do not configure this parameter, the default value is <b>C</b>.</description></item>
        /// <item><description>Valid values for <b>ctype</b>: You can execute the <c>SELECT DISTINCT collctype FROM pg_collation;</c> statement to query the values. If you do not configure this parameter, the default value is <b>en_US.utf8</b>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbk</para>
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// <para>The collation. This parameter is only supported for ApsaraDB RDS for MySQL instances. Specify a collation that matches the character set. For example, if the character set is utf8mb4, the collation must be utf8mb4_bin or utf8mb4_general_ci.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbk_chinese_ci</para>
        /// </summary>
        [NameInMap("CollationName")]
        [Validation(Required=false)]
        public string CollationName { get; set; }

        /// <summary>
        /// <para>The description of the database. The description must be 2 to 256 characters in length. It must start with a Chinese or English letter and can contain digits, Chinese characters, English letters, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>It cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBDescription")]
        [Validation(Required=false)]
        public string DBDescription { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 64 characters in length.</description></item>
        /// <item><description>It must start with a letter and end with a letter or digit.</description></item>
        /// <item><description>It can contain lowercase letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The database name must be unique within the instance.</description></item>
        /// <item><description>For other invalid characters, see <a href="https://help.aliyun.com/document_detail/26317.html">Reserved keywords</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_mysql</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
