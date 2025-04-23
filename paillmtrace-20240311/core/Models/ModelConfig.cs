// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ModelConfig : TeaModel {
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("IsSelfHost")]
        [Validation(Required=false)]
        public bool? IsSelfHost { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        [NameInMap("TopP")]
        [Validation(Required=false)]
        public float? TopP { get; set; }

        [NameInMap("UseFunctionCall")]
        [Validation(Required=false)]
        public bool? UseFunctionCall { get; set; }

    }

}
