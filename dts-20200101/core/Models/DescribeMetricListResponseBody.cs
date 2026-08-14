// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMetricListResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend error code, which is an incrementing number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The monitoring statistics information.</para>
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
            /// <para>The record timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650872310000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the %s placeholder in the <b>ErrMessage</b> error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Type</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code corresponding to the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>InternetOut</b>: outbound Internet traffic, in bytes.</description></item>
        /// <item><description><b>diskusage_utilization</b>: disk usage.</description></item>
        /// <item><description><b>IntranetInRate</b>: inbound internal network traffic, in bytes.</description></item>
        /// <item><description><b>InternetIn</b>: inbound Internet traffic, in bytes.</description></item>
        /// <item><description><b>cpu_total</b>: CPU utilization.</description></item>
        /// <item><description><b>memory_usedutilization</b>: memory utilization.</description></item>
        /// <item><description><b>IntranetOutRate</b>: outbound internal network traffic, in bytes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query a cluster or a node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLUSTER</b>: cluster.</description></item>
        /// <item><description><b>NODE</b>: node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The observation value.</para>
        /// <list type="bullet">
        /// <item><description>If <b>MetricType</b> is set to <b>NODE</b>, the value is <b>nodeid</b>.</description></item>
        /// <item><description>If <b>MetricType</b> is set to <b>CLUSTER</b>, the value is the ID of the dedicated cluster, which can be obtained by calling the ListDedicatedCluster operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-jhjnjjn</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The observation interval in seconds. The minimum interval is 15 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
