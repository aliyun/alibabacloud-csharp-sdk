// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DeleteCostUnitRequest : TeaModel {
        /// <summary>
        /// The user ID of the cost center owner.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public long? OwnerUid { get; set; }

        /// <summary>
        /// The ID of the cost center. A value of -1 indicates the root cost center.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UnitId")]
        [Validation(Required=false)]
        public long? UnitId { get; set; }

    }

}
