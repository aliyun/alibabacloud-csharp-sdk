// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class RenewAppGroupRequest : TeaModel {
        /// <summary>
        /// <para>The renewal request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PrepayOrderInfo Body { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74db41d8cd3c784209093aa76afbe89e</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
