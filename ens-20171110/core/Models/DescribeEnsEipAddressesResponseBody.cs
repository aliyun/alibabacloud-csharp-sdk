// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the EIP.</para>
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
                /// <para>The ID of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-5sainglpw7qfem3icir4s****</para>
                /// </summary>
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                /// <summary>
                /// <para>The time when the EIP was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624885274000</para>
                /// </summary>
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                /// <summary>
                /// <para>The peak bandwidth of the EIP. Default value: 5. Valid values: <b>5</b> to <b>10000</b>. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The billing method of the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PrePaid</b>: subscription.</description></item>
                /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The description of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the ENS node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-xian-telecom</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the instance that is associated with the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-5sc3kum2e0sz34wbqrws9****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the instance that is associated with the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EnsInstance</b>: ENS instance in a VPC</description></item>
                /// <item><description><b>SlbInstance</b>: SLB instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SlbInstance</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The metering method of the EIP.</para>
                /// <list type="bullet">
                /// <item><description><b>95BandwidthByMonth</b>: Pay by monthly 95th percentile bandwidth</description></item>
                /// <item><description><b>PayByBandwidth</b>: Pay by bandwidth</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>95BandwidthByMonth</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.10.10</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The running status of the EIP. This parameter is returned if the EIP is a secondary EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Stopped</b></description></item>
                /// <item><description><b>Running</b></description></item>
                /// <item><description><b>Starting</b></description></item>
                /// <item><description><b>Stopping</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Stopped</para>
                /// </summary>
                [NameInMap("IpStatus")]
                [Validation(Required=false)]
                public string IpStatus { get; set; }

                /// <summary>
                /// <para>The Internet service provider (ISP). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cmcc</b>: China Mobile</description></item>
                /// <item><description><b>unicom</b>: China Unicom</description></item>
                /// <item><description><b>telecom</b>: China Telecom</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cmcc</para>
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                /// <summary>
                /// <para>The name of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the EIP is a secondary EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Standby")]
                [Validation(Required=false)]
                public bool? Standby { get; set; }

                /// <summary>
                /// <para>The status of the EIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Associating</b></description></item>
                /// <item><description><b>Unassociating</b></description></item>
                /// <item><description><b>InUse</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTags Tags { get; set; }
                public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTagsTag> Tag { get; set; }
                    public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <term><b>Obsolete</b></term>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagKey { get; set; }

                        /// <term><b>Obsolete</b></term>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagValue { get; set; }

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
