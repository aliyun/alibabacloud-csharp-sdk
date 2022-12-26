// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateSolutionRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public int? ContentType { get; set; }

        [NameInMap("PerspectiveCodes")]
        [Validation(Required=false)]
        public List<string> PerspectiveCodes { get; set; }

        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public long? SolutionId { get; set; }

    }

}
