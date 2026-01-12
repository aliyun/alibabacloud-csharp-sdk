// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class LLMConfig : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public LLMConfigConfig Config { get; set; }
        public class LLMConfigConfig : TeaModel {
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

        }

        [NameInMap("modelServiceName")]
        [Validation(Required=false)]
        public string ModelServiceName { get; set; }

    }

}
