// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class CreateEntityShrinkRequest : TeaModel {
        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public long? DialogId { get; set; }

        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("Members")]
        [Validation(Required=false)]
        public string MembersShrink { get; set; }

        [NameInMap("Regex")]
        [Validation(Required=false)]
        public string Regex { get; set; }

    }

}
