// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFlowMetricRequest : TeaModel {
        /// <summary>
        /// <para>End Time. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description><para>UNIX timestamp: the number of milliseconds elapsed since January 1, 1970.</para>
        /// </description></item>
        /// <item><description><para>Format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// </description></item>
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
        /// <para>The instance ID, which can be either a cloud computr ID or a premium public bandwidth plan ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecd-fwq23f13<b><b>ornp-6inxqsvcyv6z8</b></b></para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type. You can select either cloud computer type or premium public bandwidth type. If you select cloud computer type, the <c>InstanceId</c> and <c>MetricType</c> must be filled in with a cloud computer ID and its corresponding traffic type. The same applies to premium public bandwidth.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The type of monitoring metric. Supports monitoring data for inbound and outbound bandwidth of cloud computers, as well as inbound and outbound bandwidth for public network access of premium public bandwidth.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intranetOutRate</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The statistic period of monitoring data. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The Region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to obtain the list of Regions supported by Elastic Desktop Service (EDS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Start Time. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description><para>UNIX timestamp: the number of milliseconds elapsed since January 1, 1970.</para>
        /// </description></item>
        /// <item><description><para>Format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// </description></item>
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
