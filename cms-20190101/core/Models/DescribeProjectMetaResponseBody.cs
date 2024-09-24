// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProjectMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C2061B2-3B1B-43BF-A4A4-C53426F479C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the cloud service.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeProjectMetaResponseBodyResources Resources { get; set; }
        public class DescribeProjectMetaResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeProjectMetaResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeProjectMetaResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CDN</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The tags. Tags are used to filter services.</para>
                /// <para>Tags are returned in the following format: <c>[{&quot;name&quot;:&quot;Tag key&quot;,&quot;value&quot;:&quot;Tag value&quot;}, {&quot;name&quot;:&quot;Tag key&quot;,&quot;value&quot;:&quot;Tag value&quot;}]</c>. The following tags are commonly used:</para>
                /// <list type="bullet">
                /// <item><description>alertUnit: the unit of the metric value in alerts. If the unit is small, the original metric value may be too large. In this case, you can use the <c>alertUnit</c> tag to specify an appropriate unit. This tag is used in CloudMonitor.</description></item>
                /// <item><description>minAlertPeriod: the minimum time interval to report a new alert. The interval at which monitoring data is reported. The value is usually 1 minute.</description></item>
                /// <item><description>metricCategory: the service specification. Example: kvstore_sharding. Some Alibaba Cloud services have multiple specifications that are defined in the same namespace. This parameter is used to identify the specifications.</description></item>
                /// <item><description>is_alarm: indicates whether an alert rule can be configured. We recommend that you do not use the special tags in the CloudMonitor console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;groupFlag&quot;:true}]</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The namespace of the cloud service. Format: <c>acs_Service name abbreviation</c>. For more information about namespaces, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_cdn</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true: The request was successful. false: The request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
