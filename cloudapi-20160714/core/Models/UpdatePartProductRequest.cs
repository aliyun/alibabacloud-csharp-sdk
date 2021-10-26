// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class UpdatePartProductRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("Segment")]
        [Validation(Required=false)]
        public int? Segment { get; set; }

        [NameInMap("SubscribeMode")]
        [Validation(Required=false)]
        public int? SubscribeMode { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("CateSecondId")]
        [Validation(Required=false)]
        public List<long?> CateSecondId { get; set; }

        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public List<long?> UserGroup { get; set; }

    }

}
