// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The character set.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for MySQL or MariaDB databases: <b>utf8, gbk, latin1, and utf8mb4</b></para>
        /// </description></item>
        /// <item><description><para>Valid values for SQL Server databases: <b>Chinese_PRC_CI_AS, Chinese_PRC_CS_AS, SQL_Latin1_General_CP1_CI_AS, SQL_Latin1_General_CP1_CS_AS, and Chinese_PRC_BIN</b></para>
        /// </description></item>
        /// <item><description><para>Valid values for PostgreSQL databases: a value in the <c>Character set,&lt;Collate&gt;,&lt;Ctype&gt;</c> format. Example: <c>UTF8,C,en_US.utf8</c>.</para>
        /// <list type="bullet">
        /// <item><description>Valid values for the character set: <b>KOI8U, UTF8, WIN866, WIN874, WIN1250, WIN1251, WIN1252, WIN1253, WIN1254, WIN1255, WIN1256, WIN1257, WIN1258, EUC_CN, EUC_KR, EUC_TW, EUC_JP, EUC_JIS_2004, KOI8R, MULE_INTERNAL, LATIN1, LATIN2, LATIN3, LATIN4, LATIN5, LATIN6, LATIN7, LATIN8, LATIN9, LATIN10, ISO_8859_5, ISO_8859_6, ISO_8859_7, ISO_8859_8, and SQL_ASCII</b></description></item>
        /// <item><description>Valid values for the <b>Collate</b> field: You can execute the <c>SELECT DISTINCT collname FROM pg_collation;</c> statement to obtain the field value. The default value is <b>C</b>.</description></item>
        /// <item><description>Valid values for the <b>Ctype</b> field: You can execute the <c>SELECT DISTINCT collctype FROM pg_collation;</c> statement to obtain the field value. The default value is <b>en_US.utf8</b>.</description></item>
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
        /// <para>The description of the database. The description must be 2 to 256 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The description must start with a letter.</para>
        /// <remarks>
        /// <para>The value cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Database for testing</para>
        /// </summary>
        [NameInMap("DBDescription")]
        [Validation(Required=false)]
        public string DBDescription { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> operation to query the ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 64 characters in length.</description></item>
        /// <item><description>The name must start with a lowercase letter and end with a lowercase letter or digit.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must be unique within the instance.</description></item>
        /// <item><description>For more information about invalid characters, see <a href="https://help.aliyun.com/document_detail/26317.html">Forbidden keywords table</a>.</description></item>
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
