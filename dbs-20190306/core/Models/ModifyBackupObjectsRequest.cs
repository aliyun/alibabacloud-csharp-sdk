// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyBackupObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The backup objects that are defined in a JSON string in the following format:</para>
        /// <pre><c>[
        ///     {
        ///         &quot;DBName&quot;:&quot;The name of the database that you want to back up&quot;,
        ///         &quot;SchemaName&quot;:&quot;The name of the schema that you want to back up&quot;,
        ///         &quot;TableIncludes&quot;:[{
        ///             &quot;TableName&quot;:&quot;The name of the table that you want to back up&quot;
        ///         }],
        ///         &quot;TableExcludes&quot;:[{
        ///             &quot;TableName&quot;:&quot;The name of the table that you want to exclude during the backup&quot;
        ///         }]
        ///     }
        /// ]
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description><para>If you specify only <c>DBName</c> and do not specify objects of lower levels, all objects in the database are backed up.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>DBName</c> and some objects of lower levels, only the specified objects are backed up by default. You can use the following regular expressions to define object names:</para>
        /// <list type="bullet">
        /// <item><description>A period <c>.</c> matches any single character except <c>\\r\\n</c>.</description></item>
        /// <item><description>An asterisk <c>*</c> matches zero or more occurrences of a preceding subexpression. For example, <c>h.*llo</c> matches strings such as <c>hllo</c> and <c>heeeello</c>.</description></item>
        /// <item><description>A question mark <c>?</c> matches zero or one occurrence of a preceding subexpression. For example, <c>h.?llo</c> matches strings such as <c>hllo</c> and <c>hello</c>, but not <c>haello</c>.</description></item>
        /// <item><description>Character set <c>[Characters]</c> matches a character included in the brackets ([ ]). For example, <c>h[ae]llo</c> matches <c>hallo</c> and <c>hello</c>.</description></item>
        /// <item><description>Negative character set <c>[^Characters]</c> does not match a character in the brackets ([ ]). For example, <c>h[^ae]llo</c> matches <c>hcllo</c> and <c>hdllo</c>, but not <c>hallo</c> or <c>hello</c>.</description></item>
        /// <item><description>Character range <c>[character1-character2]</c> matches any character included in the range from <c>character1 to character2</c>, such as <c>[0-9]</c> and <c>[a-z]</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> <c>SchemaName</c> and <c>NewSchemaName</c> apply only to SQL Server databases. Use <c>DBName</c> and <c>NewDBName</c> to specify the names of other databases.</para>
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
        /// <para>The ID of the backup schedule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1h****usfa</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
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
