// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PolicyClassInfo : TeaModel {
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("attachableResourceTypes")]
        [Validation(Required=false)]
        public List<string> AttachableResourceTypes { get; set; }

        [NameInMap("classId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        [NameInMap("configExample")]
        [Validation(Required=false)]
        public string ConfigExample { get; set; }

        [NameInMap("deprecated")]
        [Validation(Required=false)]
        public bool? Deprecated { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("enableLog")]
        [Validation(Required=false)]
        public bool? EnableLog { get; set; }

        [NameInMap("executePriority")]
        [Validation(Required=false)]
        public string ExecutePriority { get; set; }

        [NameInMap("executeStage")]
        [Validation(Required=false)]
        public string ExecuteStage { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
