// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListDNADBRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the media fingerprint libraries. We recommend that you query at most 10 libraries at a time. Separate multiple library IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2288c6ca184c0e47098a5b665e2a12****,78dc866518b843259669df58ed30****</para>
        /// </summary>
        [NameInMap("DBIds")]
        [Validation(Required=false)]
        public string DBIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

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
