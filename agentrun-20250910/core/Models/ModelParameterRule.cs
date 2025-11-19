// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelParameterRule : TeaModel {
        [NameInMap("default")]
        [Validation(Required=false)]
        public object Default { get; set; }

        [NameInMap("max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        [NameInMap("min")]
        [Validation(Required=false)]
        public int? Min { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
