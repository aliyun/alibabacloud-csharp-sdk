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
        /// <para>For valid values, see References <a href="url">https://www.postgresql.org/docs/current/multibyte.html</a>.</para>
        /// <para>Default value: UTF8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF8</para>
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// <para>The collation parameter of the database, which specifies the string comparison and sorting rules.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The locale must be compatible with the character set specified by the CharacterSetName parameter.</description></item>
        /// <item><description>Valid values for Collate: You can run the <c>SELECT DISTINCT collname FROM pg_collation;</c> command to query the valid values. If this parameter is not specified, the default value is en_US.utf8.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Collate")]
        [Validation(Required=false)]
        public string Collate { get; set; }

        /// <summary>
        /// <para>The character type parameter of the database, which specifies the character classification and case conversion rules.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The locale must be compatible with the character set specified by the CharacterSetName parameter.</description></item>
        /// <item><description>You can run the <c>SELECT DISTINCT collctype FROM pg_collation;</c> command to query the valid values. If this parameter is not specified, the default value is en_US.utf8.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Ctype")]
        [Validation(Required=false)]
        public string Ctype { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
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
        /// <para>The name of the database. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It can contain only letters, digits, and underscores (_).</description></item>
        /// <item><description>It must start with a letter.</description></item>
        /// <item><description>It can be up to 63 characters in length.</description></item>
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
        /// <item><description><para>It must start with a Chinese character or a letter.</para>
        /// </description></item>
        /// <item><description><para>It cannot start with http:// or https://.</para>
        /// </description></item>
        /// <item><description><para>It can contain Chinese characters, letters, underscores (_), hyphens (-), and digits.</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 256 characters in length.</para>
        /// </description></item>
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
        /// <item><description><para>It can contain only lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start with a lowercase letter and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It cannot start with gp.</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 16 characters in length.</para>
        /// </description></item>
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
