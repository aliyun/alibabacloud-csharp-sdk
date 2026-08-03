// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchGetTrainTaskResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("voiceList")]
        [Validation(Required=false)]
        public List<BatchGetTrainTaskResponseBodyVoiceList> VoiceList { get; set; }
        public class BatchGetTrainTaskResponseBodyVoiceList : TeaModel {
            [NameInMap("aliyunSubId")]
            [Validation(Required=false)]
            public string AliyunSubId { get; set; }

            [NameInMap("auditFailMessage")]
            [Validation(Required=false)]
            public string AuditFailMessage { get; set; }

            [NameInMap("auditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("resSpecType")]
            [Validation(Required=false)]
            public string ResSpecType { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("trainFailMessage")]
            [Validation(Required=false)]
            public string TrainFailMessage { get; set; }

            [NameInMap("trainStatus")]
            [Validation(Required=false)]
            public string TrainStatus { get; set; }

            [NameInMap("useScene")]
            [Validation(Required=false)]
            public string UseScene { get; set; }

            [NameInMap("voiceMaterial")]
            [Validation(Required=false)]
            public BatchGetTrainTaskResponseBodyVoiceListVoiceMaterial VoiceMaterial { get; set; }
            public class BatchGetTrainTaskResponseBodyVoiceListVoiceMaterial : TeaModel {
                [NameInMap("voiceId")]
                [Validation(Required=false)]
                public long? VoiceId { get; set; }

                [NameInMap("voiceLanguage")]
                [Validation(Required=false)]
                public string VoiceLanguage { get; set; }

                [NameInMap("voiceUrl")]
                [Validation(Required=false)]
                public string VoiceUrl { get; set; }

            }

        }

    }

}
