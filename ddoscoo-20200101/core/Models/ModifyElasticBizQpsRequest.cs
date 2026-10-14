// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyElasticBizQpsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> to query the IDs of all Anti-DDoS instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The metering method for the burstable QPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>month</b>: Monthly 95th percentile</para>
        /// </description></item>
        /// <item><description><para><b>day</b>: Daily 95th percentile</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The burstable QPS value. After burstable QPS is enabled, the default value is three times the basic QPS, but it cannot exceed the maximum burstable QPS:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Anti-DDoS Proxy (Chinese Mainland) IPv4 instance</b>: The maximum value is 300,000 QPS.</para>
        /// </description></item>
        /// <item><description><para><b>Anti-DDoS Proxy (Chinese Mainland) IPv6 instance</b>: The maximum value is 100,000 QPS.</para>
        /// </description></item>
        /// <item><description><para><b>Anti-DDoS Proxy (Outside Chinese Mainland) instance</b>: The maximum value is 150,000 QPS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("OpsElasticQps")]
        [Validation(Required=false)]
        public long? OpsElasticQps { get; set; }

    }

}
