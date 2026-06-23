// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListResourceGroupsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListResourceGroupsResponseBodyPagingInfo : TeaModel {
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
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of resource groups.</para>
            /// </summary>
            [NameInMap("ResourceGroupList")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyPagingInfoResourceGroupList> ResourceGroupList { get; set; }
            public class ListResourceGroupsResponseBodyPagingInfoResourceGroupList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2kqofrgXXXXX</para>
                /// </summary>
                [NameInMap("AliyunResourceGroupId")]
                [Validation(Required=false)]
                public string AliyunResourceGroupId { get; set; }

                /// <summary>
                /// <para>A list of Alibaba Cloud tags.</para>
                /// </summary>
                [NameInMap("AliyunResourceTags")]
                [Validation(Required=false)]
                public List<ListResourceGroupsResponseBodyPagingInfoResourceGroupListAliyunResourceTags> AliyunResourceTags { get; set; }
                public class ListResourceGroupsResponseBodyPagingInfoResourceGroupListAliyunResourceTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The creation time of the resource group, as a 64-bit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The user ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11075500042XXXXX</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The ID of the default Virtual Private Cloud (VPC) bound to the general-purpose resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m2et4f3oc8msfbccXXXXX</para>
                /// </summary>
                [NameInMap("DefaultVpcId")]
                [Validation(Required=false)]
                public string DefaultVpcId { get; set; }

                /// <summary>
                /// <para>The ID of the default vSwitch bound to the general-purpose resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf8usrhs7hjd9amsXXXXX</para>
                /// </summary>
                [NameInMap("DefaultVswicthId")]
                [Validation(Required=false)]
                public string DefaultVswicthId { get; set; }

                /// <summary>
                /// <para>The unique identifier of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>common_resource_group</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the order for the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c442b330-3b10-4584-959e-736e4edXXXXX</para>
                /// </summary>
                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                /// <summary>
                /// <para>The billing method of the resource group. <c>PrePaid</c> indicates subscription and <c>PostPaid</c> indicates pay-as-you-go.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// <para>The description of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Create a general-purpose resource group for common tasks.</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The type of the resource group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>CommonV2</c>: The new general-purpose resource group.</para>
                /// </description></item>
                /// <item><description><para><c>ExclusiveDataIntegration</c>: The exclusive resource group for data integration.</para>
                /// </description></item>
                /// <item><description><para><c>ExclusiveScheduler</c>: The exclusive resource group for scheduling.</para>
                /// </description></item>
                /// <item><description><para><c>ExclusiveDataService</c>: The exclusive resource group for data services.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CommonV2</para>
                /// </summary>
                [NameInMap("ResourceGroupType")]
                [Validation(Required=false)]
                public string ResourceGroupType { get; set; }

                /// <summary>
                /// <para>The specifications of the resource group.</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public ListResourceGroupsResponseBodyPagingInfoResourceGroupListSpec Spec { get; set; }
                public class ListResourceGroupsResponseBodyPagingInfoResourceGroupListSpec : TeaModel {
                    /// <summary>
                    /// <para>The number of resource units.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
                    /// <para>The resource specifications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2CU</para>
                    /// </summary>
                    [NameInMap("Standard")]
                    [Validation(Required=false)]
                    public string Standard { get; set; }

                }

                /// <summary>
                /// <para>The status of the resource group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Normal</c>: Running.</para>
                /// </description></item>
                /// <item><description><para><c>Stop</c>: Frozen due to expiration.</para>
                /// </description></item>
                /// <item><description><para><c>Deleted</c>: Released.</para>
                /// </description></item>
                /// <item><description><para><c>Creating</c>: Creation in progress.</para>
                /// </description></item>
                /// <item><description><para><c>CreateFailed</c>: Creation failed.</para>
                /// </description></item>
                /// <item><description><para><c>Updating</c>: Update in progress.</para>
                /// </description></item>
                /// <item><description><para><c>UpdateFailed</c>: Update failed.</para>
                /// </description></item>
                /// <item><description><para><c>Deleting</c>: Release in progress.</para>
                /// </description></item>
                /// <item><description><para><c>DeleteFailed</c>: Release failed.</para>
                /// </description></item>
                /// <item><description><para><c>Timeout</c>: The operation timed out.</para>
                /// </description></item>
                /// <item><description><para><c>Freezed</c>: Frozen.</para>
                /// </description></item>
                /// <item><description><para><c>Starting</c>: Starting.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
