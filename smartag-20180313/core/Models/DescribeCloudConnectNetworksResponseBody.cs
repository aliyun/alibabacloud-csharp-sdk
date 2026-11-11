// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeCloudConnectNetworksResponseBody : TeaModel {
        [NameInMap("CloudConnectNetworks")]
        [Validation(Required=false)]
        public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworks CloudConnectNetworks { get; set; }
        public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworks : TeaModel {
            [NameInMap("CloudConnectNetwork")]
            [Validation(Required=false)]
            public List<DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetwork> CloudConnectNetwork { get; set; }
            public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetwork : TeaModel {
                [NameInMap("AssociatedCenId")]
                [Validation(Required=false)]
                public string AssociatedCenId { get; set; }

                [NameInMap("AssociatedCenOwnerId")]
                [Validation(Required=false)]
                public string AssociatedCenOwnerId { get; set; }

                [NameInMap("AssociatedCenStatus")]
                [Validation(Required=false)]
                public string AssociatedCenStatus { get; set; }

                [NameInMap("AssociatedCloudBoxCount")]
                [Validation(Required=false)]
                public string AssociatedCloudBoxCount { get; set; }

                [NameInMap("AssociatedVpcStatus")]
                [Validation(Required=false)]
                public string AssociatedVpcStatus { get; set; }

                [NameInMap("AvailableCloudBoxCount")]
                [Validation(Required=false)]
                public string AvailableCloudBoxCount { get; set; }

                [NameInMap("CcnId")]
                [Validation(Required=false)]
                public string CcnId { get; set; }

                [NameInMap("CenStatusErrorCode")]
                [Validation(Required=false)]
                public string CenStatusErrorCode { get; set; }

                [NameInMap("CenStatusErrorMessage")]
                [Validation(Required=false)]
                public string CenStatusErrorMessage { get; set; }

                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InterworkingStatus")]
                [Validation(Required=false)]
                public string InterworkingStatus { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NewAgw")]
                [Validation(Required=false)]
                public bool? NewAgw { get; set; }

                [NameInMap("ProcessingCenId")]
                [Validation(Required=false)]
                public string ProcessingCenId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SnatCidrBlock")]
                [Validation(Required=false)]
                public string SnatCidrBlock { get; set; }

                [NameInMap("Subnet")]
                [Validation(Required=false)]
                public string Subnet { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTags Tags { get; set; }
                public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTagsTag> Tag { get; set; }
                    public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TrNetworkConfig")]
                [Validation(Required=false)]
                public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTrNetworkConfig TrNetworkConfig { get; set; }
                public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTrNetworkConfig : TeaModel {
                    [NameInMap("CidrAllocationMode")]
                    [Validation(Required=false)]
                    public string CidrAllocationMode { get; set; }

                    [NameInMap("RegionBindingList")]
                    [Validation(Required=false)]
                    public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTrNetworkConfigRegionBindingList RegionBindingList { get; set; }
                    public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTrNetworkConfigRegionBindingList : TeaModel {
                        [NameInMap("RegionBinding")]
                        [Validation(Required=false)]
                        public List<DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTrNetworkConfigRegionBindingListRegionBinding> RegionBinding { get; set; }
                        public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTrNetworkConfigRegionBindingListRegionBinding : TeaModel {
                            [NameInMap("CidrBlock")]
                            [Validation(Required=false)]
                            public string CidrBlock { get; set; }

                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                            [NameInMap("RelayCidrBlock")]
                            [Validation(Required=false)]
                            public string RelayCidrBlock { get; set; }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                            [NameInMap("TransitRouterId")]
                            [Validation(Required=false)]
                            public string TransitRouterId { get; set; }

                        }

                    }

                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                [NameInMap("VpcNetworkConfig")]
                [Validation(Required=false)]
                public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkVpcNetworkConfig VpcNetworkConfig { get; set; }
                public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkVpcNetworkConfig : TeaModel {
                    [NameInMap("CidrAllocationMode")]
                    [Validation(Required=false)]
                    public string CidrAllocationMode { get; set; }

                    [NameInMap("RegionBindingList")]
                    [Validation(Required=false)]
                    public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkVpcNetworkConfigRegionBindingList RegionBindingList { get; set; }
                    public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkVpcNetworkConfigRegionBindingList : TeaModel {
                        [NameInMap("RegionBinding")]
                        [Validation(Required=false)]
                        public List<DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkVpcNetworkConfigRegionBindingListRegionBinding> RegionBinding { get; set; }
                        public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkVpcNetworkConfigRegionBindingListRegionBinding : TeaModel {
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                            [NameInMap("RelayCidrBlock")]
                            [Validation(Required=false)]
                            public string RelayCidrBlock { get; set; }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                            [NameInMap("VpcCidrBlock")]
                            [Validation(Required=false)]
                            public string VpcCidrBlock { get; set; }

                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                        }

                    }

                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                [NameInMap("VpcStatusErrorCode")]
                [Validation(Required=false)]
                public string VpcStatusErrorCode { get; set; }

                [NameInMap("VpcStatusErrorMessage")]
                [Validation(Required=false)]
                public string VpcStatusErrorMessage { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F2A0B80-D6D1-4764-8D77-38067DBBA345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
