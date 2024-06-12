// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GenerateAggregateResourceInventoryRequest : TeaModel {
        /// <summary>
        /// The IDs of member accounts in the account group. Separate multiple member account IDs with commas (,).
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIds { get; set; }

        /// <summary>
        /// The ID of the account group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The IDs of the regions to which the resources belong. Separate multiple region IDs with commas (,).
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        [NameInMap("ResourceDeleted")]
        [Validation(Required=false)]
        public int? ResourceDeleted { get; set; }

        /// <summary>
        /// The resource types. Separate multiple resource types with commas (,).
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
