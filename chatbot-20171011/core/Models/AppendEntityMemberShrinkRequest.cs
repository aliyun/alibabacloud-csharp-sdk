// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class AppendEntityMemberShrinkRequest : TeaModel {
        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        [NameInMap("Member")]
        [Validation(Required=false)]
        public string MemberShrink { get; set; }

    }

}
