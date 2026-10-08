// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDatabaseRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The character set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL/MariaDB: <b>utf8, gbk, latin1, utf8mb4</b></description></item>
        /// <item><description>SQL Server: <b>Chinese_PRC_CI_AS, Chinese_PRC_CS_AS, SQL_Latin1_General_CP1_CI_AS, SQL_Latin1_General_CP1_CS_AS, Chinese_PRC_BIN</b></description></item>
        /// <item><description>PostgreSQL: You must specify the character set, Collate, and Ctype in the format of <c>Character set,&lt;Collate&gt;,&lt;Ctype&gt;</c>. Example: <c>UTF8,C,en_US.utf8</c>.<list type="bullet">
        /// <item><description>Valid values for the character set: <b>KOI8U, UTF8, WIN866, WIN874, WIN1250, WIN1251, WIN1252, WIN1253, WIN1254, WIN1255, WIN1256, WIN1257, WIN1258, EUC_CN, EUC_KR, EUC_TW, EUC_JP, EUC_JIS_2004, KOI8R, MULE_INTERNAL, LATIN1, LATIN2, LATIN3, LATIN4, LATIN5, LATIN6, LATIN7, LATIN8, LATIN9, LATIN10, ISO_8859_5, ISO_8859_6, ISO_8859_7, ISO_8859_8, SQL_ASCII</b>.</description></item>
        /// <item><description>Valid values for <b>Collate</b>: You can run the <c>SELECT DISTINCT collname FROM pg_collation;</c> command to query the valid values. If this parameter is not specified, the default value <b>C</b> is used.</description></item>
        /// <item><description>Valid values for <b>Ctype</b>: You can run the <c>SELECT DISTINCT collctype FROM pg_collation;</c> command to query the valid values. If this parameter is not specified, the default value <b>en_US.utf8</b> is used.</description></item>
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
        /// <para>The collation. This parameter is supported only for ApsaraDB RDS for MySQL instances. Specify a collation that matches the character set. For example, if the character set is utf8mb4, the collation must be utf8mb4_bin or utf8mb4_general_ci.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbk_chinese_ci</para>
        /// </summary>
        [NameInMap("CollationName")]
        [Validation(Required=false)]
        public string CollationName { get; set; }

        /// <summary>
        /// <para>The database description. The description must be 2 to 256 characters in length and can contain letters, digits, Chinese characters, underscores (_), and hyphens (-). The description must start with a Chinese character or a letter.</para>
        /// <remarks>
        /// <para>The description cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBDescription")]
        [Validation(Required=false)]
        public string DBDescription { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 64 characters in length.</description></item>
        /// <item><description>The name must start with a letter and end with a letter or digit.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The database name must be unique within the instance.</description></item>
        /// <item><description>For more information about invalid characters, see <a href="https://help.aliyun.com/document_detail/26317.html">Reserved words</a>.</description></item>
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
