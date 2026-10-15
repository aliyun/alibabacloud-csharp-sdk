// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AllocateCostUnitResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source financial unit. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>0 indicates the unallocated financial unit ID.</description></item>
        /// <item><description>A value greater than 0 indicates an allocated financial unit ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromUnitId")]
        [Validation(Required=false)]
        public long? FromUnitId { get; set; }

        /// <summary>
        /// <para>The ID of the owner of the source financial unit. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273394581313325532</para>
        /// </summary>
        [NameInMap("FromUnitUserId")]
        [Validation(Required=false)]
        public long? FromUnitUserId { get; set; }

        /// <summary>
        /// <para>The list of resource instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public List<AllocateCostUnitResourceRequestResourceInstanceList> ResourceInstanceList { get; set; }
        public class AllocateCostUnitResourceRequestResourceInstanceList : TeaModel {
            /// <summary>
            /// <para>The attached resource type of the attached-resource-based instance. This parameter is required only for attached-resource-based product instances.</para>
            /// <list type="bullet">
            /// <item><description>Currently, eight commodities support attached resources. Their commodity codes are oss, dcdn, snapshot, vod, cdn, live, and cbwp.</description></item>
            /// <item><description>This attached resource field is typically obtained by calling QueryCostUnitResource to retrieve all billing instances (including attached-resource-based instances with attached resource information) under a specific financial unit (including the unallocated unit) of a user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qwer1-cn-beijing</para>
            /// </summary>
            [NameInMap("ApportionCode")]
            [Validation(Required=false)]
            public string ApportionCode { get; set; }

            /// <summary>
            /// <para>The commodity code of the billing instance. This parameter is required.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The instance ID of the billing instance. This parameter is required.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou;standard</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the billing instance. This parameter is required.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>273394581313325532</para>
            /// </summary>
            [NameInMap("ResourceUserId")]
            [Validation(Required=false)]
            public long? ResourceUserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the destination financial unit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: moves the allocated resource to the unallocated state.</description></item>
        /// <item><description>A value greater than 0: allocates the resource to the specified financial unit.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186419</para>
        /// </summary>
        [NameInMap("ToUnitId")]
        [Validation(Required=false)]
        public long? ToUnitId { get; set; }

        /// <summary>
        /// <para>The ID of the owner of the destination financial unit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>241021678450941490</para>
        /// </summary>
        [NameInMap("ToUnitUserId")]
        [Validation(Required=false)]
        public long? ToUnitUserId { get; set; }

    }

}
