// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateViewPointRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public GenerateViewPointRequestReferenceData ReferenceData { get; set; }
        public class GenerateViewPointRequestReferenceData : TeaModel {
            [NameInMap("MiniDoc")]
            [Validation(Required=false)]
            public List<string> MiniDoc { get; set; }

        }

    }

}
