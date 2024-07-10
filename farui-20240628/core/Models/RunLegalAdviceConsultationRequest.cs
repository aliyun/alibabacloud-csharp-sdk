// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunLegalAdviceConsultationRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public RunLegalAdviceConsultationRequestAssistant Assistant { get; set; }
        public class RunLegalAdviceConsultationRequestAssistant : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("metaData")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetaData { get; set; }

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

        [NameInMap("thread")]
        [Validation(Required=false)]
        public RunLegalAdviceConsultationRequestThread Thread { get; set; }
        public class RunLegalAdviceConsultationRequestThread : TeaModel {
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<RunLegalAdviceConsultationRequestThreadMessages> Messages { get; set; }
            public class RunLegalAdviceConsultationRequestThreadMessages : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

        }

    }

}
