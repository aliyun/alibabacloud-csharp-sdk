// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF5189484043</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The display name of the resource group.</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public GetResourceGroupResponseBodyResourceGroup ResourceGroup { get; set; }
        public class GetResourceGroupResponseBodyResourceGroup : TeaModel {
            /// <summary>
            /// <para>The identifier of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The resource group is being created.</description></item>
            /// <item><description>OK: The resource group is created.</description></item>
            /// <item><description>PendingDelete: The resource group is waiting to be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The tags that are added to the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-9gLOoK****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The resource group is being created.</description></item>
            /// <item><description>OK: The resource group is created.</description></item>
            /// <item><description>PendingDelete: The resource group is waiting to be deleted.</description></item>
            /// <item><description>Deleting: The resource group is being deleted.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RegionStatuses")]
            [Validation(Required=false)]
            public GetResourceGroupResponseBodyResourceGroupRegionStatuses RegionStatuses { get; set; }
            public class GetResourceGroupResponseBodyResourceGroupRegionStatuses : TeaModel {
                [NameInMap("RegionStatus")]
                [Validation(Required=false)]
                public List<GetResourceGroupResponseBodyResourceGroupRegionStatusesRegionStatus> RegionStatus { get; set; }
                public class GetResourceGroupResponseBodyResourceGroupRegionStatusesRegionStatus : TeaModel {
                    /// <summary>
                    /// <para>The ID of the Alibaba Cloud account to which the resource group belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-qingdao</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OK</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the resource group in all regions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public GetResourceGroupResponseBodyResourceGroupTags Tags { get; set; }
            public class GetResourceGroupResponseBodyResourceGroupTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<GetResourceGroupResponseBodyResourceGroupTagsTag> Tag { get; set; }
                public class GetResourceGroupResponseBodyResourceGroupTagsTag : TeaModel {
                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k1</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

        }

    }

}
