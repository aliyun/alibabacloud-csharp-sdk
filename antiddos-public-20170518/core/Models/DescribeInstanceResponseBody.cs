// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the assets.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyInstanceList InstanceList { get; set; }
        public class DescribeInstanceResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyInstanceListInstance> Instance { get; set; }
            public class DescribeInstanceResponseBodyInstanceListInstance : TeaModel {
                /// <summary>
                /// <para>The basic protection threshold for the asset. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5200</para>
                /// </summary>
                [NameInMap("BlackholeThreshold")]
                [Validation(Required=false)]
                public int? BlackholeThreshold { get; set; }

                /// <summary>
                /// <para>The traffic scrubbing threshold for the asset. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("DefenseBpsThreshold")]
                [Validation(Required=false)]
                public int? DefenseBpsThreshold { get; set; }

                /// <summary>
                /// <para>The packet scrubbing threshold for the asset. Unit: packets per second (pps).</para>
                /// 
                /// <b>Example:</b>
                /// <para>70000</para>
                /// </summary>
                [NameInMap("DefensePpsThreshold")]
                [Validation(Required=false)]
                public int? DefensePpsThreshold { get; set; }

                /// <summary>
                /// <para>The burstable protection threshold for the asset. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12310</para>
                /// </summary>
                [NameInMap("ElasticThreshold")]
                [Validation(Required=false)]
                public int? ElasticThreshold { get; set; }

                /// <summary>
                /// <para>The ID of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1cb6x80tfgocid****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The IP address of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121.199.XX.XX</para>
                /// </summary>
                [NameInMap("InstanceIp")]
                [Validation(Required=false)]
                public string InstanceIp { get; set; }

                /// <summary>
                /// <para>The name of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>launch-advisor-2021****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The DDoS mitigation status of the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mitigating</b>: indicates that traffic scrubbing is triggered for the asset.</description></item>
                /// <item><description><b>blackholed</b>: indicates that blackhole filtering is triggered for the asset.</description></item>
                /// <item><description><b>normal</b>: indicates that the instance is normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The type of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The IP protocol that is supported by the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v4</b>: IPv4</description></item>
                /// <item><description><b>v6</b>: IPv6</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the asset is associated with an Anti-DDoS Origin Basic instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsBgppack")]
                [Validation(Required=false)]
                public bool? IsBgppack { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C728D7E9-9A39-52E0-966B-5C33118BDBB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
