// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AllocateCostUnitResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source cost center.</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 indicates that the resources to be transferred have not been allocated to a cost center.</description></item>
        /// <item><description>A value greater than 0 indicates the ID of an existing cost center.</description></item>
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
        /// <para>The user ID of the owner of the source cost center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273394581313325532</para>
        /// </summary>
        [NameInMap("FromUnitUserId")]
        [Validation(Required=false)]
        public long? FromUnitUserId { get; set; }

        /// <summary>
        /// <para>The resource instances to be transferred.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public List<AllocateCostUnitResourceRequestResourceInstanceList> ResourceInstanceList { get; set; }
        public class AllocateCostUnitResourceRequestResourceInstanceList : TeaModel {
            /// <summary>
            /// <para>The split item of the shared instance. This parameter is required only for shared instances.</para>
            /// <list type="bullet">
            /// <item><description>Eight cloud services support bill splitting. The commodity codes of the eight services are oss, dcdn, snapshot, vod, cdn, live, and cbwp.</description></item>
            /// <item><description>You can obtain the split item of a shared instance by calling QueryCostUnitResource operation to obtain all resource instances within a cost center.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qwer1-cn-beijing</para>
            /// </summary>
            [NameInMap("ApportionCode")]
            [Validation(Required=false)]
            public string ApportionCode { get; set; }

            /// <summary>
            /// <para>The commodity code of the resource instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The ID of the resource instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou;standard</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The user ID of the resource instance owner.</para>
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
        /// <para>The ID of the destination cost center.</para>
        /// <list type="bullet">
        /// <item><description>A value of -1 indicates that the allocated resources are changed to unallocated.</description></item>
        /// <item><description>A value greater than 0 indicates the ID of an existing cost center.</description></item>
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
        /// <para>The user ID of the owner of the destination cost center.</para>
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
