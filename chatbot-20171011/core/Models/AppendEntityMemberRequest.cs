// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class AppendEntityMemberRequest : TeaModel {
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        [NameInMap("Member")]
        [Validation(Required=false)]
        public string Member { get; set; }

    }

}
