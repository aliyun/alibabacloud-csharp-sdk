// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class RenewAppGroupRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public PrepayOrderInfo Body { get; set; }

        /// <summary>
        /// Guaranteed request idempotence
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
