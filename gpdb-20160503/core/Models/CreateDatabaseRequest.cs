// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The character set.</para>
        /// <para>For more information about the value range, see Document <a href="url">https://www.postgresql.org/docs/current/multibyte.html</a>.</para>
        /// <para>Default value: UTF-8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF8</para>
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// <para>Database locale parameter (specifies string comparison/sorting rules).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The locale must be compatible with the character set specified by the CharacterSetName parameter.</para>
        /// </description></item>
        /// <item><description><para>Valid values for the Collate field: You can execute the SELECT DISTINCT collname FROM pg_collation; statement to obtain the field value. The default value is en_US.utf8.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Collate")]
        [Validation(Required=false)]
        public string Collate { get; set; }

        /// <summary>
        /// <para>Database locale parameter (defines character classification/case conversion rules).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The locale must be compatible with the character set specified by the CharacterSetName parameter.</para>
        /// </description></item>
        /// <item><description><para>You can execute the SELECT DISTINCT collctype FROM pg_collation; statement to obtain the field value. The default value is en_US.utf8.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Ctype")]
        [Validation(Required=false)]
        public string Ctype { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <list type="bullet">
        /// <item><description>Only contains letters, digits, and underscores (_).</description></item>
        /// <item><description>Must start with a letter.</description></item>
        /// <item><description>Up to 63 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The description of the database.</para>
        /// <list type="bullet">
        /// <item><description>Must start with a letter.</description></item>
        /// <item><description>Cannot start with http:// or https://.</description></item>
        /// <item><description>Only contains letters, underscores (_), hyphens (-), and digits.</description></item>
        /// <item><description>Must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>A user management database storing customer profiles.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The owner of the table.</para>
        /// <list type="bullet">
        /// <item><description>Only contains lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>Must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>Cannot start with gp.</description></item>
        /// <item><description>Must be 2 to 16 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testadb</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

    }

}
