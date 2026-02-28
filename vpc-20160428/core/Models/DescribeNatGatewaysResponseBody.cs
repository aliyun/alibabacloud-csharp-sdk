// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public DescribeNatGatewaysResponseBodyNatGateways NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            [NameInMap("NatGateway")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGateway> NatGateway { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysNatGateway : TeaModel {
                [NameInMap("AccessMode")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayAccessMode AccessMode { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayAccessMode : TeaModel {
                    [NameInMap("ModeValue")]
                    [Validation(Required=false)]
                    public string ModeValue { get; set; }

                    [NameInMap("TunnelType")]
                    [Validation(Required=false)]
                    public string TunnelType { get; set; }

                }

                [NameInMap("AutoPay")]
                [Validation(Required=false)]
                public bool? AutoPay { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EcsMetricEnabled")]
                [Validation(Required=false)]
                public bool? EcsMetricEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MULTI_BINDED</para>
                /// </summary>
                [NameInMap("EipBindMode")]
                [Validation(Required=false)]
                public string EipBindMode { get; set; }

                [NameInMap("EnableSessionLog")]
                [Validation(Required=false)]
                public string EnableSessionLog { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("ForwardTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds ForwardTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds : TeaModel {
                    [NameInMap("ForwardTableId")]
                    [Validation(Required=false)]
                    public List<string> ForwardTableId { get; set; }

                }

                [NameInMap("FullNatTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds FullNatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds : TeaModel {
                    [NameInMap("FullNatTableId")]
                    [Validation(Required=false)]
                    public List<string> FullNatTableId { get; set; }

                }

                [NameInMap("IcmpReplyEnabled")]
                [Validation(Required=false)]
                public bool? IcmpReplyEnabled { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                [NameInMap("IpLists")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists IpLists { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists : TeaModel {
                    [NameInMap("IpList")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList> IpList { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList : TeaModel {
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                        [NameInMap("PrivateIpAddress")]
                        [Validation(Required=false)]
                        public string PrivateIpAddress { get; set; }

                        [NameInMap("SnatEntryEnabled")]
                        [Validation(Required=false)]
                        public bool? SnatEntryEnabled { get; set; }

                        [NameInMap("UsingStatus")]
                        [Validation(Required=false)]
                        public string UsingStatus { get; set; }

                    }

                }

                [NameInMap("IpPrefixList")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixList IpPrefixList { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixList : TeaModel {
                    [NameInMap("IpPrefixList")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixListIpPrefixList> IpPrefixList { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpPrefixListIpPrefixList : TeaModel {
                        [NameInMap("IpPrefix")]
                        [Validation(Required=false)]
                        public string IpPrefix { get; set; }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                [NameInMap("NatGatewayPrivateInfo")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo NatGatewayPrivateInfo { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo : TeaModel {
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public string EniInstanceId { get; set; }

                    [NameInMap("EniType")]
                    [Validation(Required=false)]
                    public string EniType { get; set; }

                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    [NameInMap("MaxBandwidth")]
                    [Validation(Required=false)]
                    public int? MaxBandwidth { get; set; }

                    [NameInMap("MaxSessionEstablishRate")]
                    [Validation(Required=false)]
                    public int? MaxSessionEstablishRate { get; set; }

                    [NameInMap("MaxSessionQuota")]
                    [Validation(Required=false)]
                    public int? MaxSessionQuota { get; set; }

                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

                [NameInMap("NatType")]
                [Validation(Required=false)]
                public string NatType { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("PrivateLinkEnabled")]
                [Validation(Required=false)]
                public bool? PrivateLinkEnabled { get; set; }

                [NameInMap("PrivateLinkMode")]
                [Validation(Required=false)]
                public string PrivateLinkMode { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecurityProtectionEnabled")]
                [Validation(Required=false)]
                public bool? SecurityProtectionEnabled { get; set; }

                [NameInMap("SnatTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds SnatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds : TeaModel {
                    [NameInMap("SnatTableId")]
                    [Validation(Required=false)]
                    public List<string> SnatTableId { get; set; }

                }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags Tags { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag> Tag { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of NAT gateway entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
