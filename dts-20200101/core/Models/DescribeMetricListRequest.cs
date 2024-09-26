// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMetricListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. **The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k2gm967v16f****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the end of the time range to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642476194000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Default value: <b>ALIYUN</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the metrics of the cluster or a node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLUSTER</b>: query the metrics of the cluster.</description></item>
        /// <item><description><b>NODE</b>: query the metrics of a node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NODE</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("OwnerID")]
        [Validation(Required=false)]
        public string OwnerID { get; set; }

        /// <summary>
        /// <para>The monitored object. If the <b>MetricType</b> parameter is set to <b>NODE</b>, set this parameter to the ID of the node that is monitored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodeid</para>
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

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the beginning of the time range to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642476144000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
