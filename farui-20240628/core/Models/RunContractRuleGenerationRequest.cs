// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractRuleGenerationRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public RunContractRuleGenerationRequestAssistant Assistant { get; set; }
        public class RunContractRuleGenerationRequestAssistant : TeaModel {
            [NameInMap("metaData")]
            [Validation(Required=false)]
            public RunContractRuleGenerationRequestAssistantMetaData MetaData { get; set; }
            public class RunContractRuleGenerationRequestAssistantMetaData : TeaModel {
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
