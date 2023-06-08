// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SubmitTextTo2DAvatarVideoTaskRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public SubmitTextTo2DAvatarVideoTaskRequestApp App { get; set; }
        public class SubmitTextTo2DAvatarVideoTaskRequestApp : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

        }

        [NameInMap("AudioInfo")]
        [Validation(Required=false)]
        public SubmitTextTo2DAvatarVideoTaskRequestAudioInfo AudioInfo { get; set; }
        public class SubmitTextTo2DAvatarVideoTaskRequestAudioInfo : TeaModel {
            [NameInMap("PitchRate")]
            [Validation(Required=false)]
            public int? PitchRate { get; set; }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        [NameInMap("AvatarInfo")]
        [Validation(Required=false)]
        public SubmitTextTo2DAvatarVideoTaskRequestAvatarInfo AvatarInfo { get; set; }
        public class SubmitTextTo2DAvatarVideoTaskRequestAvatarInfo : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("VideoInfo")]
        [Validation(Required=false)]
        public SubmitTextTo2DAvatarVideoTaskRequestVideoInfo VideoInfo { get; set; }
        public class SubmitTextTo2DAvatarVideoTaskRequestVideoInfo : TeaModel {
            [NameInMap("AlphaFormat")]
            [Validation(Required=false)]
            public int? AlphaFormat { get; set; }

            [NameInMap("BackgroundImageUrl")]
            [Validation(Required=false)]
            public string BackgroundImageUrl { get; set; }

            [NameInMap("IsAlpha")]
            [Validation(Required=false)]
            public bool? IsAlpha { get; set; }

            [NameInMap("IsSubtitles")]
            [Validation(Required=false)]
            public bool? IsSubtitles { get; set; }

            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public int? Resolution { get; set; }

        }

    }

}
