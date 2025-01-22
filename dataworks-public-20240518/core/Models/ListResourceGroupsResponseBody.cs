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
            /// <para>The resource groups returned.</para>
            /// </summary>
            [NameInMap("ResourceGroupList")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyPagingInfoResourceGroupList> ResourceGroupList { get; set; }
            public class ListResourceGroupsResponseBodyPagingInfoResourceGroupList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-aek2kqofrgXXXXX</para>
                /// </summary>
                [NameInMap("AliyunResourceGroupId")]
                [Validation(Required=false)]
                public string AliyunResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11075500042XXXXX</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-m2et4f3oc8msfbccXXXXX</para>
                /// </summary>
                [NameInMap("DefaultVpcId")]
                [Validation(Required=false)]
                public string DefaultVpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-uf8usrhs7hjd9amsXXXXX</para>
                /// </summary>
                [NameInMap("DefaultVswicthId")]
                [Validation(Required=false)]
                public string DefaultVswicthId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>common_resource_group</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c442b330-3b10-4584-959e-736e4edXXXXX</para>
                /// </summary>
                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                /// <summary>
                /// <para>The billing method of the resource group. Valid values: PrePaid and PostPaid. The value PrePaid indicates the subscription billing method, and the value PostPaid indicates the pay-as-you-go billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建用于普通任务的通用资源组</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The type of the resource group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CommonV2: serverless resource group</description></item>
                /// <item><description>ExclusiveDataIntegration: exclusive resource group for Data Integration</description></item>
                /// <item><description>ExclusiveScheduler: exclusive resource group for scheduling</description></item>
                /// <item><description>ExclusiveDataService: exclusive resource group for DataService Studio</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CommonV2</para>
                /// </summary>
                [NameInMap("ResourceGroupType")]
                [Validation(Required=false)]
                public string ResourceGroupType { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public ListResourceGroupsResponseBodyPagingInfoResourceGroupListSpec Spec { get; set; }
                public class ListResourceGroupsResponseBodyPagingInfoResourceGroupListSpec : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
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
                /// <item><description>Normal: The resource group is running or in use.</description></item>
                /// <item><description>Stop: The resource group is expired.</description></item>
                /// <item><description>Deleted: The resource group is released or destroyed.</description></item>
                /// <item><description>Creating: The resource group is being started.</description></item>
                /// <item><description>CreateFailed: The resource group fails to be started.</description></item>
                /// <item><description>Updating: The resource group is being scaled in or out, or the configurations of the resource group are being changed.</description></item>
                /// <item><description>UpdateFailed: The resource group fails to be scaled out or upgraded.</description></item>
                /// <item><description>Deleting: The resource group is being released or destroyed.</description></item>
                /// <item><description>DeleteFailed: The resource group fails to be released or destroyed.</description></item>
                /// <item><description>Timeout: The operations that are performed on the resource group time out.</description></item>
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
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
