// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DisableAccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the activation code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-bp12g5gwup0yzmce****</para>
        /// </summary>
        [NameInMap("AccessTokenId")]
        [Validation(Required=false)]
        public string AccessTokenId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
