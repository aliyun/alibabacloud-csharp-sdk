// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the EIPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;106.14.194.193\&quot;]</para>
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEnsEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEnsEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                /// <summary>
                /// <para>EIP的实例ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-5sainglpw7qfem3icir4s****</para>
                /// </summary>
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                /// <summary>
                /// <para>EIP的创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624885274000</para>
                /// </summary>
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                /// <summary>
                /// <para>EIP的带宽峰值，默认值为5。取值范围：<b>5</b>~<b>10000</b>，单位：Mbps。</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>EIP的计费模式。</para>
                /// <list type="bullet">
                /// <item><description><para><b>PrePaid</b>：包年包月。</para>
                /// </description></item>
                /// <item><description><para><b>PostPaid</b>：按量计费。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>EIP的描述信息。</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>ENS节点ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-xian-telecom</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("IcmpReplyEnabled")]
                [Validation(Required=false)]
                public bool? IcmpReplyEnabled { get; set; }

                /// <summary>
                /// <para>当前绑定的实例的ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-5sc3kum2e0sz34wbqrws9****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>要绑定的云产品实例的类型，取值： </para>
                /// <list type="bullet">
                /// <item><description><para><b>EnsInstance</b>：VPC类型的ENS实例。</para>
                /// </description></item>
                /// <item><description><para><b>SlbInstance</b>：负载均衡实例。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SlbInstance</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>EIP的计费方式。</para>
                /// <list type="bullet">
                /// <item><description><para><b>95BandwidthByMonth</b>：月95峰值带宽。</para>
                /// </description></item>
                /// <item><description><para><b>PayByBandwidth</b>：固定带宽计费。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>95BandwidthByMonth</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>EIP的IP地址。</para>
                /// 
                /// <b>Example:</b>
                /// <para>120.XXX.XXX.4</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>如果该弹性IP是备用EIP时，表示当前EIP的运行状态。</para>
                /// <list type="bullet">
                /// <item><description><b>Stopped</b>：已停止。</description></item>
                /// <item><description><b>Running</b>：运行中。</description></item>
                /// <item><description><b>Starting</b>：启动中。</description></item>
                /// <item><description><b>Stopping</b>：停止中。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Stopped</para>
                /// </summary>
                [NameInMap("IpStatus")]
                [Validation(Required=false)]
                public string IpStatus { get; set; }

                /// <summary>
                /// <para>运营商，取值：</para>
                /// <list type="bullet">
                /// <item><description><b>cmcc</b>：中国移动。</description></item>
                /// <item><description><b>unicom</b>：中国联通。</description></item>
                /// <item><description><b>telecom</b>：中国电信。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cmcc</para>
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                /// <summary>
                /// <para>EIP实例名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>该EIP是否是备用。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Standby")]
                [Validation(Required=false)]
                public bool? Standby { get; set; }

                /// <summary>
                /// <para>EIP的状态。</para>
                /// <list type="bullet">
                /// <item><description><para><b>Associating</b>：绑定中。</para>
                /// </description></item>
                /// <item><description><para><b>Unassociating</b>：解绑中。   </para>
                /// </description></item>
                /// <item><description><para><b>InUse</b>：已分配。   </para>
                /// </description></item>
                /// <item><description><para><b>Available</b>：可用。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>标签集合。</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTags Tags { get; set; }
                public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTagsTag> Tag { get; set; }
                    public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTagsTag : TeaModel {
                        /// <summary>
                        /// <para>标签键</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <term><b>Obsolete</b></term>
                        /// 
                        /// <summary>
                        /// <para>标签键。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagKey { get; set; }

                        /// <term><b>Obsolete</b></term>
                        /// 
                        /// <summary>
                        /// <para>标签值。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagValue { get; set; }

                        /// <summary>
                        /// <para>标签值。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number. Valid values: an integer that is greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: <b>10</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8629F679-B51D-4194-A1CC-5D8F504C362B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
