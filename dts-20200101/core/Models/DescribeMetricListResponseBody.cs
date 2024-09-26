// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMetricListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned by the backend service. The number is incremented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The monitoring statistics.</para>
        /// </summary>
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public List<DescribeMetricListResponseBodyDataPoints> DataPoints { get; set; }
        public class DescribeMetricListResponseBodyDataPoints : TeaModel {
            /// <summary>
            /// <para>The statistical value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15.25</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public float? Statistics { get; set; }

            /// <summary>
            /// <para>The timestamp of the record. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650872310000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace the %s variable in the <b>ErrMessage</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Type</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned for an exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>InternetOut</b>: the outbound traffic over the Internet. Unit: byte.</description></item>
        /// <item><description><b>diskusage_utilization</b>: the disk usage.</description></item>
        /// <item><description><b>IntranetInRate</b>: the inbound traffic over the internal network. Unit: byte.</description></item>
        /// <item><description><b>InternetIn</b>: the inbound traffic from the Internet. Unit: byte.</description></item>
        /// <item><description><b>cpu_total</b>: the CPU utilization.</description></item>
        /// <item><description><b>memory_usedutilization</b>: the memory usage.</description></item>
        /// <item><description><b>IntranetOutRate</b>: the outbound traffic over the internal network. Unit: byte.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>Indicates whether the metrics of the cluster or a node are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLUSTER</b>: The metrics of the cluster are queried.</description></item>
        /// <item><description><b>NODE</b>: The metrics of a node are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The monitored object.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>MetricType</b> parameter is set to <b>NODE</b>, the value of this parameter is the ID of the node that is monitored.****</description></item>
        /// <item><description>If the <b>MetricType</b> parameter is set to <b>CLUSTER</b>, the value of this parameter is the ID of the dedicated cluster. You can obtain the ID by calling the ListDedicatedCluster operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-jhjnjjn</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The monitoring interval. Unit: seconds. Minimum value: 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
