// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AppendInstancesToPrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// <para>The list of global aggregation instances. The value is a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;sourceName&quot;: &quot;Data source name- ArmsPrometheus No.1&quot;, &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;, &quot;userId&quot;:&quot;UserID&quot;, &quot;clusterId&quot;:&quot;ClusterId&quot;, }, { &quot;sourceName&quot;: &quot;Data source name - MetrcStore No.2&quot;, &quot;sourceType&quot;:&quot;MetricStore&quot;, &quot;dataSource&quot;:&quot;Remote read endpoint of the MetricStore&quot;, &quot;extras&quot;:{ &quot;username&quot;:&quot;BasicAuthUsername&quot;, &quot;password&quot;:&quot;BasicAuthPassword&quot; } }, { &quot;sourceName&quot;: &quot;Custom &quot;, &quot;sourceType&quot;:&quot;CustomPrometheus&quot;, &quot;dataSource&quot;:&quot;Remote read endpoint of the self-managed Prometheus data source&quot;, &quot;extras&quot;:{ &quot;username&quot;:&quot;BasicAuthUsername&quot;, &quot;password&quot;:&quot;BasicAuthPassword&quot; } }, { &quot;sourceName&quot;: &quot;Other one &quot;, &quot;sourceType&quot;:&quot;Others&quot;, &quot;dataSource&quot;:&quot;Endpoint of another data source such as Tencent remote read&quot;, &quot;headers&quot;:{ &quot;AnyHeaderToFill&quot;:&quot;Headers to be filled&quot; }, &quot;extras&quot;:{ &quot;username&quot;:&quot;BasicAuthUsername&quot;, &quot;password&quot;:&quot;BasicAuthPassword&quot; } } // ....... more addre ]</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// <para>The ID of the global aggregation instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global-v2-cn-1670100631025794-6gjc0qgb</para>
        /// </summary>
        [NameInMap("GlobalViewClusterId")]
        [Validation(Required=false)]
        public string GlobalViewClusterId { get; set; }

        /// <summary>
        /// <para>The name of the global aggregation instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zyGlobalView</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
