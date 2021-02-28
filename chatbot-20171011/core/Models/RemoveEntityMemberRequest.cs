// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class RemoveEntityMemberRequest : TeaModel {
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        [NameInMap("RemoveType")]
        [Validation(Required=false)]
        public string RemoveType { get; set; }

        [NameInMap("Member")]
        [Validation(Required=false)]
        public string Member { get; set; }

    }

}
