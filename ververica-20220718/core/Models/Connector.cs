// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Connector : TeaModel {
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        [NameInMap("dependencies")]
        [Validation(Required=false)]
        public List<string> Dependencies { get; set; }

        [NameInMap("lookup")]
        [Validation(Required=false)]
        public bool? Lookup { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<Property> Properties { get; set; }

        [NameInMap("sink")]
        [Validation(Required=false)]
        public bool? Sink { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public bool? Source { get; set; }

        [NameInMap("supportedFormats")]
        [Validation(Required=false)]
        public List<string> SupportedFormats { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
