// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddPrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// <para>The list of aggregation instances. The value is a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[         {             &quot;sourceName&quot;: &quot;数据源名称- ArmsPrometheus No.1&quot;,             &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,             &quot;userId&quot;:&quot;UserID&quot;,             &quot;clusterId&quot;:&quot;ClusterId&quot;,         },         {             &quot;sourceName&quot;: &quot;数据源名称 - MetrcStore No.2&quot;,             &quot;sourceType&quot;:&quot;MetricStore&quot;,             &quot;dataSource&quot;:&quot;MetricStore的 remote read 地址&quot;,             &quot;extras&quot;:{                 &quot;username&quot;:&quot;BasicAuthUsername&quot;,                 &quot;password&quot;:&quot;BasicAuthPassword&quot;             }         },         {             &quot;sourceName&quot;: &quot;Custom &quot;,             &quot;sourceType&quot;:&quot;CustomPrometheus&quot;,             &quot;dataSource&quot;:&quot;自建Prometheus数据源 remoteread地址&quot;,             &quot;extras&quot;:{                 &quot;username&quot;:&quot;BasicAuthUsername&quot;,                 &quot;password&quot;:&quot;BasicAuthPassword&quot;             }         },         {           	&quot;sourceName&quot;: &quot;Other one &quot;,             &quot;sourceType&quot;:&quot;Others&quot;,             &quot;dataSource&quot;:&quot;其他数据源如Tencent remoteread地址&quot;,             &quot;headers&quot;:{                 &quot;AnyHeaderToFill&quot;:&quot;需要填充的Headers&quot;             },             &quot;extras&quot;:{                 &quot;username&quot;:&quot;BasicAuthUsername&quot;,                 &quot;password&quot;:&quot;BasicAuthPassword&quot;             }         }   // ....... more addre ]</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// <para>The name of the aggregation instance.</para>
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

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2eq4pecazwfy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddPrometheusGlobalViewRequestTag> Tag { get; set; }
        public class AddPrometheusGlobalViewRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http.status_code</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
