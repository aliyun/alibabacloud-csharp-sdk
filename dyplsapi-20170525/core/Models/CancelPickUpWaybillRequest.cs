// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CancelPickUpWaybillRequest : TeaModel {
        /// <summary>
        /// The cancellation reason.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CancelDesc")]
        [Validation(Required=false)]
        public string CancelDesc { get; set; }

        /// <summary>
        /// The ID of the external order.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
