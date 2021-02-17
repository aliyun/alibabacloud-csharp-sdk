// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListVideoAudiosResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Audios")]
        [Validation(Required=false)]
        public List<ListVideoAudiosResponseBodyAudios> Audios { get; set; }
        public class ListVideoAudiosResponseBodyAudios : TeaModel {
            [NameInMap("SourcePosition")]
            [Validation(Required=false)]
            public string SourcePosition { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("RemarksC")]
            [Validation(Required=false)]
            public string RemarksC { get; set; }

            [NameInMap("AudioDuration")]
            [Validation(Required=false)]
            public float? AudioDuration { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("AudioTextsStatus")]
            [Validation(Required=false)]
            public string AudioTextsStatus { get; set; }

            [NameInMap("AudioFormat")]
            [Validation(Required=false)]
            public string AudioFormat { get; set; }

            [NameInMap("RemarksD")]
            [Validation(Required=false)]
            public string RemarksD { get; set; }

            [NameInMap("ProcessModifyTime")]
            [Validation(Required=false)]
            public string ProcessModifyTime { get; set; }

            [NameInMap("ProcessFailReason")]
            [Validation(Required=false)]
            public string ProcessFailReason { get; set; }

            [NameInMap("AudioUri")]
            [Validation(Required=false)]
            public string AudioUri { get; set; }

            [NameInMap("AudioRate")]
            [Validation(Required=false)]
            public int? AudioRate { get; set; }

            [NameInMap("AudioTextsModifyTime")]
            [Validation(Required=false)]
            public string AudioTextsModifyTime { get; set; }

            [NameInMap("RemarksA")]
            [Validation(Required=false)]
            public string RemarksA { get; set; }

            [NameInMap("AudioTexts")]
            [Validation(Required=false)]
            public List<ListVideoAudiosResponseBodyAudiosAudioTexts> AudioTexts { get; set; }
            public class ListVideoAudiosResponseBodyAudiosAudioTexts : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("Library")]
                [Validation(Required=false)]
                public string Library { get; set; }

                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public float? BeginTime { get; set; }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public int? ChannelId { get; set; }

                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public float? EmotionValue { get; set; }

                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Person")]
                [Validation(Required=false)]
                public string Person { get; set; }

                [NameInMap("SilenceDuration")]
                [Validation(Required=false)]
                public float? SilenceDuration { get; set; }

            }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("SourceUri")]
            [Validation(Required=false)]
            public string SourceUri { get; set; }

            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            [NameInMap("AudioTextsFailReason")]
            [Validation(Required=false)]
            public string AudioTextsFailReason { get; set; }

            [NameInMap("RemarksB")]
            [Validation(Required=false)]
            public string RemarksB { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

    }

}
