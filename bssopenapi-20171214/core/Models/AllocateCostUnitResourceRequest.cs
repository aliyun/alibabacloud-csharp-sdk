// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AllocateCostUnitResourceRequest : TeaModel {
        /// <summary>
        /// The ID of the source cost center.
        /// 
        /// *   A value of 0 indicates that the resources to be transferred have not been allocated to a cost center.
        /// *   A value greater than 0 indicates the ID of an existing cost center.
        /// </summary>
        [NameInMap("FromUnitId")]
        [Validation(Required=false)]
        public long? FromUnitId { get; set; }

        /// <summary>
        /// The user ID of the owner of the source cost center.
        /// </summary>
        [NameInMap("FromUnitUserId")]
        [Validation(Required=false)]
        public long? FromUnitUserId { get; set; }

        /// <summary>
        /// The resource instances to be transferred.
        /// </summary>
        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public List<AllocateCostUnitResourceRequestResourceInstanceList> ResourceInstanceList { get; set; }
        public class AllocateCostUnitResourceRequestResourceInstanceList : TeaModel {
            /// <summary>
            /// The split item of the shared instance. This parameter is required only for shared instances.
            /// 
            /// *   Eight cloud services support bill splitting. The commodity codes of the eight services are oss, dcdn, snapshot, vod, cdn, live, cbwp, and pcdn.
            /// *   You can obtain the split item of a shared instance by calling QueryCostUnitResource operation to obtain all resource instances within a cost center.
            /// </summary>
            [NameInMap("ApportionCode")]
            [Validation(Required=false)]
            public string ApportionCode { get; set; }

            /// <summary>
            /// The commodity code of the resource instance.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The ID of the resource instance.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The user ID of the resource instance owner.
            /// </summary>
            [NameInMap("ResourceUserId")]
            [Validation(Required=false)]
            public long? ResourceUserId { get; set; }

        }

        /// <summary>
        /// The ID of the destination cost center.
        /// 
        /// *   A value of -1 indicates that the allocated resources are changed to unallocated.
        /// *   A value greater than 0 indicates the ID of an existing cost center.
        /// </summary>
        [NameInMap("ToUnitId")]
        [Validation(Required=false)]
        public long? ToUnitId { get; set; }

        /// <summary>
        /// The user ID of the owner of the destination cost center.
        /// </summary>
        [NameInMap("ToUnitUserId")]
        [Validation(Required=false)]
        public long? ToUnitUserId { get; set; }

    }

}
