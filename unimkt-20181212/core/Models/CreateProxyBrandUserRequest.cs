// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CreateProxyBrandUserRequest : TeaModel {
        [NameInMap("BrandUserNick")]
        [Validation(Required=false)]
        public string BrandUserNick { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Company")]
        [Validation(Required=false)]
        public string Company { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("ContactPhone")]
        [Validation(Required=false)]
        public string ContactPhone { get; set; }

        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public long? ProxyUserId { get; set; }

    }

}
