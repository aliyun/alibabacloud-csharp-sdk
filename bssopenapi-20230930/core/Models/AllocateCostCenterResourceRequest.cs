// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class AllocateCostCenterResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source cost center. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>0 indicates that the cost center is unallocated.</description></item>
        /// <item><description>A value greater than 0 indicates an allocated cost center ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>637180</para>
        /// </summary>
        [NameInMap("FromCostCenterId")]
        [Validation(Required=false)]
        public long? FromCostCenterId { get; set; }

        /// <summary>
        /// <para>The ID of the owner of the source cost center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1529600453335198</para>
        /// </summary>
        [NameInMap("FromOwnerAccountId")]
        [Validation(Required=false)]
        public long? FromOwnerAccountId { get; set; }

        /// <summary>
        /// <para>The primary sales channel ID. If this parameter is left empty, the sales channel ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The list of resource instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public List<AllocateCostCenterResourceRequestResourceInstanceList> ResourceInstanceList { get; set; }
        public class AllocateCostCenterResourceRequestResourceInstanceList : TeaModel {
            /// <summary>
            /// <para>The attached resource type of the attached-resource instance. This parameter is required only for attached-resource product instances.</para>
            /// <list type="bullet">
            /// <item><description>Currently, eight commodities support attached resources. The commodity codes are oss, dcdn, snapshot, vod, cdn, live, and cbwp.</description></item>
            /// <item><description>You can call the QueryCostUnitResource operation to obtain all billing instances (including attached-resource instances with their attached resources) under a specific cost center (including the unallocated cost center) of a user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qwer1-cn-beijing</para>
            /// </summary>
            [NameInMap("ApportionCode")]
            [Validation(Required=false)]
            public string ApportionCode { get; set; }

            /// <summary>
            /// <para>The attached resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>split-item-test1</para>
            /// </summary>
            [NameInMap("ApportionName")]
            [Validation(Required=false)]
            public string ApportionName { get; set; }

            /// <summary>
            /// <para>The commodity code of the billing instance. This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity name of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESOURCE_UDR</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The billing granularity ID. This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou;standard</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The product code, which is the same as the product code in User Center bills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("PipCode")]
            [Validation(Required=false)]
            public string PipCode { get; set; }

            /// <summary>
            /// <para>The resources related to the resource instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>related-resource</para>
            /// </summary>
            [NameInMap("RelatedResources")]
            [Validation(Required=false)]
            public string RelatedResources { get; set; }

            /// <summary>
            /// <para>The resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xihe_mpp</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou;standard:app</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The custom nickname of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-test-1</para>
            /// </summary>
            [NameInMap("ResourceNick")]
            [Validation(Required=false)]
            public string ResourceNick { get; set; }

            /// <summary>
            /// <para>The resource source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AUTO_ALLOCATE: automatic allocation.</description></item>
            /// <item><description>MANUAL_ALLOCATE: manual allocation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO_ALLOCATE</para>
            /// </summary>
            [NameInMap("ResourceSource")]
            [Validation(Required=false)]
            public string ResourceSource { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The tag of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-test1</para>
            /// </summary>
            [NameInMap("ResourceTag")]
            [Validation(Required=false)]
            public string ResourceTag { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCU</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the billing instance. This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>273394581313325532</para>
            /// </summary>
            [NameInMap("ResourceUserId")]
            [Validation(Required=false)]
            public long? ResourceUserId { get; set; }

            /// <summary>
            /// <para>The resource ownership username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceUserName")]
            [Validation(Required=false)]
            public string ResourceUserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the destination cost center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: moves the allocated resource to the unallocated state.</description></item>
        /// <item><description>A value greater than 0: allocates the resource to the specified cost center.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>638288</para>
        /// </summary>
        [NameInMap("ToCostCenterId")]
        [Validation(Required=false)]
        public long? ToCostCenterId { get; set; }

    }

}
