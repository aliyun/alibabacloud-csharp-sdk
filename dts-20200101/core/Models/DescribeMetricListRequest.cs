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
        /// <para>Ensures the idempotency of the request. Generate a parameter value from your client to make sure that the value is unique among different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k2gm967v16f****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The end timestamp, in milliseconds.</para>
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
        /// <item><description><b>InternetOut</b>: outbound Internet traffic, in bytes.</description></item>
        /// <item><description><b>diskusage_utilization</b>: disk usage.</description></item>
        /// <item><description><b>IntranetInRate</b>: inbound internal network traffic, in bytes.</description></item>
        /// <item><description><b>InternetIn</b>: inbound Internet traffic, in bytes.</description></item>
        /// <item><description><b>cpu_total</b>: CPU utilization.</description></item>
        /// <item><description><b>memory_usedutilization</b>: memory utilization.</description></item>
        /// <item><description><b>IntranetOutRate</b>: outbound internal network traffic, in bytes.</description></item>
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
        /// <para>Specifies whether to query a cluster or a node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLUSTER</b>: cluster.</description></item>
        /// <item><description><b>NODE</b>: node.</description></item>
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
        /// <para>The observation value. If <b>MetricType</b> is set to <b>NODE</b>, the value is <b>nodeid</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodeid</para>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start timestamp, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642476144000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
