// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFlowMetricRequest : TeaModel {
        /// <summary>
        /// <para>The end time. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// <item><description>Format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1664714703743</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID. The value can be a cloud computer ID or a premium public bandwidth plan ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-fwq23f13**** or np-6inxqsvcyv6z8****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type. You can select the cloud computer type or the premium public bandwidth plan type. If you select the cloud computer type, set InstanceId and MetricType to the cloud computer ID and the traffic type of the cloud computer. The same rule applies to the premium public bandwidth plan type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The monitoring metric type. This parameter supports the inbound and outbound bandwidth of a cloud computer, and the public inbound and outbound bandwidth of a premium public bandwidth plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intranetOutRate</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since January 1, 1970.</description></item>
        /// <item><description>Format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651817220643</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
