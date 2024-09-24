// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricMetaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CCE0AF0-053C-4B13-A583-DC9A85785D49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configuration of the metrics in the resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMetricMetaListResponseBodyResources Resources { get; set; }
        public class DescribeMetricMetaListResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMetricMetaListResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMetricMetaListResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// <para>The metric description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPUUtilization</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The monitoring dimensions of the resource. Multiple monitoring dimensions are separated with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceId</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// <para>The tags of the metric, including one or more JSON strings.</para>
                /// <para>Format: <c>[{&quot;name&quot;:&quot;tag key&quot;,&quot;value&quot;:&quot;tag value&quot;}]</c>. The <c>name</c> can be repeated. The following tags are available:</para>
                /// <list type="bullet">
                /// <item><description>metricCategory: the category of the metric.</description></item>
                /// <item><description>alertEnable: indicates whether to report alerts for the metric.</description></item>
                /// <item><description>alertUnit: the unit of the metric in the alerts.</description></item>
                /// <item><description>unitFactor: the factor for metric unit conversion.</description></item>
                /// <item><description>minAlertPeriod: the minimum interval at which the alert is reported.</description></item>
                /// <item><description>productCategory: the category of the service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;name\&quot;:\&quot;alertUnit\&quot;,\&quot;value\&quot;:\&quot;Bytes\&quot;},{\&quot;name\&quot;:\&quot;minAlertPeriod\&quot;,\&quot;value\&quot;:\&quot;60\&quot;},{\&quot;name\&quot;:\&quot;metricCategory\&quot;,\&quot;value\&quot;:\&quot;instanceId\&quot;},{\&quot;name\&quot;:\&quot;instanceType\&quot;,\&quot;value\&quot;:\&quot;disaster\&quot;},{\&quot;name\&quot;:\&quot;is_alarm\&quot;,\&quot;value\&quot;:\&quot;true\&quot;},{\&quot;name\&quot;:\&quot;productCategory\&quot;,\&quot;value\&quot;:\&quot;kvstore_old\&quot;}]</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPUUtilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The namespace of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_kvstore</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The statistical periods of the metric. Multiple statistical periods are separated with commas (,).</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60,300</para>
                /// </summary>
                [NameInMap("Periods")]
                [Validation(Required=false)]
                public string Periods { get; set; }

                /// <summary>
                /// <para>The statistical method. Multiple statistical methods are separated with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average,Minimum,Maximum</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The unit of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>%</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
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
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
