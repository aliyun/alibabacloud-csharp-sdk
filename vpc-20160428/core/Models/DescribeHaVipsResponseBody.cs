// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeHaVipsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the HaVip.</para>
        /// </summary>
        [NameInMap("HaVips")]
        [Validation(Required=false)]
        public DescribeHaVipsResponseBodyHaVips HaVips { get; set; }
        public class DescribeHaVipsResponseBodyHaVips : TeaModel {
            [NameInMap("HaVip")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsHaVip> HaVip { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsHaVip : TeaModel {
                /// <summary>
                /// <para>The list of EIPs associated with the HaVip.</para>
                /// </summary>
                [NameInMap("AssociatedEipAddresses")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses AssociatedEipAddresses { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedEipAddresses : TeaModel {
                    [NameInMap("associatedEipAddresse")]
                    [Validation(Required=false)]
                    public List<string> AssociatedEipAddresse { get; set; }

                }

                /// <summary>
                /// <para>The type of the instance with which the HaVip is associated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EcsInstance</b>: Elastic Compute Service (ECS) instance</description></item>
                /// <item><description><b>NetworkInterface</b>: elastic network interface (ENI)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EcsInstance</para>
                /// </summary>
                [NameInMap("AssociatedInstanceType")]
                [Validation(Required=false)]
                public string AssociatedInstanceType { get; set; }

                /// <summary>
                /// <para>The information about the instance associated with the HaVip.</para>
                /// </summary>
                [NameInMap("AssociatedInstances")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances AssociatedInstances { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipAssociatedInstances : TeaModel {
                    [NameInMap("associatedInstance")]
                    [Validation(Required=false)]
                    public List<string> AssociatedInstance { get; set; }

                }

                /// <summary>
                /// <para>The parameter is invalid. No value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The time when the HaVip was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-07-03T14:25:26Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the HaVip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>My HaVip</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the HaVip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>havip-bp149uyvut73dpld****</para>
                /// </summary>
                [NameInMap("HaVipId")]
                [Validation(Required=false)]
                public string HaVipId { get; set; }

                /// <summary>
                /// <para>The private IP address of the HaVip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.24.5</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The ID of the active instance that is associated with the HaVip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp145q7glnuzdvz****</para>
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the HaVip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the HaVip belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the HaVip belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of the HaVip. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b>: The server group is being created.</description></item>
                /// <item><description><b>Available</b>: The FULLNAT entry is available.</description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag list.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeHaVipsResponseBodyHaVipsHaVipTags Tags { get; set; }
                public class DescribeHaVipsResponseBodyHaVipsHaVipTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeHaVipsResponseBodyHaVipsHaVipTagsTag> Tag { get; set; }
                    public class DescribeHaVipsResponseBodyHaVipsHaVipTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of tag N added to the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N added to the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceJoshua</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the vSwitch to which the HaVip belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1pkt1fba8e824ez****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the HaVip belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1kcm36tevkpms97****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
        /// <para>The number of entries per page.</para>
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
        /// <para>33E480C5-B46F-4CA5-B6FD-D77C746E86AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
