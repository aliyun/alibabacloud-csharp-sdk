// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryTagOpenStatusRequest : TeaModel {
        [NameInMap("AttributeKey")]
        [Validation(Required=false)]
        public string AttributeKey { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SubAttributeKey")]
        [Validation(Required=false)]
        public string SubAttributeKey { get; set; }

    }

}
