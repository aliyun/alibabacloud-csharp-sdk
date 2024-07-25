// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PolicyInfo : TeaModel {
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<Attachment> Attachments { get; set; }

        [NameInMap("classAlias")]
        [Validation(Required=false)]
        public string ClassAlias { get; set; }

        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("executePriority")]
        [Validation(Required=false)]
        public string ExecutePriority { get; set; }

        [NameInMap("executeStage")]
        [Validation(Required=false)]
        public string ExecuteStage { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
