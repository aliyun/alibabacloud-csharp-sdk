// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>Refer to the example JSON for parameter values. The parameters are explained as follows:</para>
        /// <list type="bullet">
        /// <item><description>dsId  --  Required  --  Data source ID</description></item>
        /// <item><description>userId -- Optional -- User identity for modifying the data source, quickbi\&quot;s userId. If provided, it will use the current userId for modification.</description></item>
        /// <item><description>dsType -- Required -- Data source type, not allowed to be modified, just pass the data source type.</description></item>
        /// <item><description>showName -- Optional -- Display name of the data source.</description></item>
        /// <item><description>address -- Optional -- Database connection string (domain or IP)</description></item>
        /// <item><description>port -- Optional -- Port</description></item>
        /// <item><description>schema --  Optional --  Database schema, only required for databases that support schemas. Example: sqlserver uses dbo by default; mysql does not support schemas.</description></item>
        /// <item><description>instance -- Optional -- Instance db</description></item>
        /// <item><description>username -- Optional -- Database username/ak</description></item>
        /// <item><description>password -- Optional -- Database key</description></item>
        /// <item><description>config -- Optional -- Additional database configuration items. Note that this data should be consistent with the different config parameters passed during creation for different data sources. Fields that do not need to be modified do not require parameters. For fields where parameters are passed, the default is to modify according to the passed parameters (including empty strings).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;schema&quot;: &quot;schema&quot;,
        ///     &quot;userId&quot;:&quot;S<em><b><b>46345&quot;,
        ///     &quot;password&quot;: &quot;Ta</b></b>34&quot;,
        ///     &quot;showName&quot;: &quot;TEST&quot;,
        ///     &quot;address&quot;: &quot;11****</em>.55&quot;,
        ///     &quot;instance&quot;: &quot;quickbi_test&quot;,
        ///     &quot;dsId&quot;: &quot;34d6d******3ca8ac267&quot;,
        ///     &quot;port&quot;: &quot;3306&quot;,
        ///     &quot;dsType&quot;: &quot;mysql&quot;,
        ///     &quot;username&quot;: &quot;root&quot;,
        ///     &quot;config&quot;:  {
        ///         &quot;initialSql&quot;: &quot;Set timezone = \&quot;-10\&quot;&quot;
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("UpdateModel")]
        [Validation(Required=false)]
        public string UpdateModel { get; set; }

    }

}
