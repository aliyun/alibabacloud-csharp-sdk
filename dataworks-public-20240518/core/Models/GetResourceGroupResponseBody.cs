// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information of the resource group.</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public GetResourceGroupResponseBodyResourceGroup ResourceGroup { get; set; }
        public class GetResourceGroupResponseBodyResourceGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group to which the resource group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2kqofrgXXXXX</para>
            /// </summary>
            [NameInMap("AliyunResourceGroupId")]
            [Validation(Required=false)]
            public string AliyunResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of Alibaba Cloud tags.</para>
            /// </summary>
            [NameInMap("AliyunResourceTags")]
            [Validation(Required=false)]
            public List<GetResourceGroupResponseBodyResourceGroupAliyunResourceTags> AliyunResourceTags { get; set; }
            public class GetResourceGroupResponseBodyResourceGroupAliyunResourceTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The creation time, represented as a 64-bit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727055811000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11075500042XXXXX</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The ID of the default VPC bound to the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-m2et4f3oc8msfbccXXXXX</para>
            /// </summary>
            [NameInMap("DefaultVpcId")]
            [Validation(Required=false)]
            public string DefaultVpcId { get; set; }

            /// <summary>
            /// <para>The ID of the default vSwitch bound to the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf8usrhs7hjd9amsXXXXX</para>
            /// </summary>
            [NameInMap("DefaultVswitchId")]
            [Validation(Required=false)]
            public string DefaultVswitchId { get; set; }

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
            /// <para>The order instance ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c442b330-3b10-4584-959e-736e4edXXXXX</para>
            /// </summary>
            [NameInMap("OrderInstanceId")]
            [Validation(Required=false)]
            public string OrderInstanceId { get; set; }

            /// <summary>
            /// <para>The billing method of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrePaid: subscription.</description></item>
            /// <item><description>PostPaid: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The remarks of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create a common resource group for common tasks</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The type of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CommonV2: new-version resource group.</description></item>
            /// <item><description>ExclusiveDataIntegration: exclusive data integration resource group.</description></item>
            /// <item><description>ExclusiveScheduler: exclusive scheduling resource group.</description></item>
            /// <item><description>ExclusiveDataService: exclusive data service resource group.</description></item>
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
            public GetResourceGroupResponseBodyResourceGroupSpec Spec { get; set; }
            public class GetResourceGroupResponseBodyResourceGroupSpec : TeaModel {
                /// <summary>
                /// <para>The resource count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The specification details.</para>
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
            /// <item><description>Normal: normal (running/in service).</description></item>
            /// <item><description>Stop: frozen (expired).</description></item>
            /// <item><description>Deleted: deleted (released/destroyed).</description></item>
            /// <item><description>Creating: being created.</description></item>
            /// <item><description>CreateFailed: creation failed.</description></item>
            /// <item><description>Updating: being updated (scaling out/scaling in/specification change in progress).</description></item>
            /// <item><description>UpdateFailed: update failed (scale-out failed/upgrade failed).</description></item>
            /// <item><description>Deleting: being deleted (being released/being destroyed).</description></item>
            /// <item><description>DeleteFailed: deletion failed (release failed/destruction failed).</description></item>
            /// <item><description>Timeout: operation timed out.</description></item>
            /// <item><description>Freezed: frozen.</description></item>
            /// <item><description>Starting: starting.</description></item>
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
