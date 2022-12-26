// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class AssociateShrinkRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public string PerspectiveShrink { get; set; }

        [NameInMap("RecommendNum")]
        [Validation(Required=false)]
        public long? RecommendNum { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
