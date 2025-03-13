// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchGetTrainTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2226A26A-26E5-5AB9-A14A-54D612FCF96A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("voiceList")]
        [Validation(Required=false)]
        public List<BatchGetTrainTaskResponseBodyVoiceList> VoiceList { get; set; }
        public class BatchGetTrainTaskResponseBodyVoiceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1524004782438111</para>
            /// </summary>
            [NameInMap("aliyunSubId")]
            [Validation(Required=false)]
            public string AliyunSubId { get; set; }

            [NameInMap("auditFailMessage")]
            [Validation(Required=false)]
            public string AuditFailMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>auditFail</para>
            /// </summary>
            [NameInMap("auditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>M</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BASIC_MODEL</para>
            /// </summary>
            [NameInMap("resSpecType")]
            [Validation(Required=false)]
            public string ResSpecType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>837091359375048704</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CopyVoice</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("trainFailMessage")]
            [Validation(Required=false)]
            public string TrainFailMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>trainFail</para>
            /// </summary>
            [NameInMap("trainStatus")]
            [Validation(Required=false)]
            public string TrainStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>realTimeInteractivity</para>
            /// </summary>
            [NameInMap("useScene")]
            [Validation(Required=false)]
            public string UseScene { get; set; }

            [NameInMap("voiceMaterial")]
            [Validation(Required=false)]
            public BatchGetTrainTaskResponseBodyVoiceListVoiceMaterial VoiceMaterial { get; set; }
            public class BatchGetTrainTaskResponseBodyVoiceListVoiceMaterial : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("voiceId")]
                [Validation(Required=false)]
                public long? VoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("voiceLanguage")]
                [Validation(Required=false)]
                public string VoiceLanguage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.voice.com">http://www.voice.com</a></para>
                /// </summary>
                [NameInMap("voiceUrl")]
                [Validation(Required=false)]
                public string VoiceUrl { get; set; }

            }

        }

    }

}
