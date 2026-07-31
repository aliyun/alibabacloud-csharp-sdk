// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateFormationCrawlerRequest : TeaModel {
        /// <summary>
        /// <para>The JSON string that contains the complete crawler configuration. This is the most important parameter. For the internal JSON structure, see the CrawlerInfo structure definition section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;sourceType&quot;: &quot;OSSWAREHOUSE&quot;,
        ///   &quot;dbName&quot;: &quot;your_target_db&quot;,
        ///   &quot;sourceInfo&quot;: {
        ///     &quot;ossSourceInfo&quot;: {
        ///       &quot;sourceMode&quot;: &quot;WAREHOUSE&quot;,
        ///       &quot;ossLocations&quot;: [&quot;oss://your-bucket/your-path/&quot;],
        ///       &quot;exclusions&quot;: [],
        ///       &quot;inclusions&quot;: []
        ///     }
        ///   },
        ///   &quot;classifiers&quot;: [&quot;csv&quot;],
        ///   &quot;schemaChangePolicy&quot;: {
        ///     &quot;updateRule&quot;: &quot;ONLY_ADD_COLUMN&quot;,
        ///     &quot;deleteRule&quot;: &quot;IGNORE&quot;
        ///   },
        ///   &quot;frequency&quot;: {
        ///     &quot;type&quot;: &quot;monthly&quot;,
        ///     &quot;cron&quot;: &quot;0+00+00+1+<em>+?+</em>&quot;
        ///   },
        ///   &quot;configuration&quot;: &quot;adb.crawler.csv.columns.specify.delimiter.char=auto\nadb.crawler.csv.columns.specify.quote.char=auto\n&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CrawlerInfo")]
        [Validation(Required=false)]
        public string CrawlerInfo { get; set; }

        /// <summary>
        /// <para>The ADB instance ID. This specifies the resource-level scope of the operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp*****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
