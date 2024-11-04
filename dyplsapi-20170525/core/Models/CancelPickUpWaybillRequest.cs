// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CancelPickUpWaybillRequest : TeaModel {
        /// <summary>
        /// <para>The cancellation reason.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;action\&quot;:\&quot;UPDATE_DESC\&quot;,\&quot;value\&quot;:\&quot;The courier is unable to pick up the package.\&quot;}</para>
        /// </summary>
        [NameInMap("CancelDesc")]
        [Validation(Required=false)]
        public string CancelDesc { get; set; }

        /// <summary>
        /// <para>The ID of the external order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1145678823****</para>
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
