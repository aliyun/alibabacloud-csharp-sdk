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
        public RemoveEntityMemberRequestMember Member { get; set; }
        public class RemoveEntityMemberRequestMember : TeaModel {
            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }
            [NameInMap("Synonyms")]
            [Validation(Required=false)]
            public List<string> Synonyms { get; set; }
        };

    }

}
