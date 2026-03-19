// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyBackupObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The backup objects, specified as a JSON string. The structure is as follows:</para>
        /// <pre><c>[
        ///     {
        ///         &quot;DBName&quot;:&quot;The name of the database to back up&quot;,
        ///         &quot;SchemaName&quot;:&quot;The name of the schema to back up&quot;,
        ///         &quot;TableIncludes&quot;:[{
        ///             &quot;TableName&quot;:&quot;The name of the table to back up&quot;
        ///         }],
        ///         &quot;TableExcludes&quot;:[{
        ///             &quot;TableName&quot;:&quot;The name of a table in the database that you do not want to back up&quot;
        ///         }]
        ///     }
        /// ]
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description><para>If you specify only <c>DBName</c> without configuring rules for sub-objects, all objects in the database are backed up.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>DBName</c> and configure rules for some objects, any objects without configured rules are not backed up by default. The following regular expressions are supported for defining object names:</para>
        /// <list type="bullet">
        /// <item><description>A period (<c>.</c>) matches any single character except `</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>`.</para>
        /// <list type="bullet">
        /// <item><description><para>An asterisk (<c>*</c>) matches the preceding subexpression zero or more times. For example, <c>h*llo</c> matches <c>hllo</c> and <c>heeeello</c>.</para>
        /// </description></item>
        /// <item><description><para>A question mark (<c>?</c>) matches the preceding subexpression zero or one time. For example, <c>h.?llo</c> matches <c>hllo</c> and <c>hello</c>, but not <c>haello</c>.</para>
        /// </description></item>
        /// <item><description><para>A character set <c>[characters]</c> matches any single character within the brackets. For example, <c>h[aello]</c> matches <c>hallo</c> and <c>hello</c>.</para>
        /// </description></item>
        /// <item><description><para>A negated character set <c>[^characters]</c> matches any single character not within the brackets. For example, <c>h[^ae]llo</c> matches <c>hcllo</c> and <c>hdllo</c>, but not <c>hallo</c> or <c>hello</c>.</para>
        /// </description></item>
        /// <item><description><para>A character range <c>[character1-character2]</c> matches any character within the specified range, such as <c>[0-9]</c> or <c>[a-z]</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><c>SchemaName</c> and <c>NewSchemaName</c> are used only for SQL Server. For other database engines, use <c>DBName</c> and <c>NewDBName</c> to specify database names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[     {         &quot;DBName&quot;:&quot;17xxx92xxxx374&quot;,         &quot;SchemaName&quot;:&quot;gy9xnj8xxxxxx&quot;,         &quot;TableIncludes&quot;:[{         	&quot;TableName&quot;:&quot;test1&quot;         }],         &quot;TableExcludes&quot;:[{             &quot;TableName&quot;:&quot;test2&quot;         }]     } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1h****usfa</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A client token to ensure the request is idempotent. This prevents the same request from being submitted multiple times.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
