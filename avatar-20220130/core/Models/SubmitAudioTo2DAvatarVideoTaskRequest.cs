// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SubmitAudioTo2DAvatarVideoTaskRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public SubmitAudioTo2DAvatarVideoTaskRequestApp App { get; set; }
        public class SubmitAudioTo2DAvatarVideoTaskRequestApp : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

        }

        [NameInMap("AvatarInfo")]
        [Validation(Required=false)]
        public SubmitAudioTo2DAvatarVideoTaskRequestAvatarInfo AvatarInfo { get; set; }
        public class SubmitAudioTo2DAvatarVideoTaskRequestAvatarInfo : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public int? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public int? Y { get; set; }

        }

        [NameInMap("Callback")]
        [Validation(Required=false)]
        public bool? Callback { get; set; }

        [NameInMap("CallbackParams")]
        [Validation(Required=false)]
        public string CallbackParams { get; set; }

        [NameInMap("ExtParams")]
        [Validation(Required=false)]
        public string ExtParams { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("VideoInfo")]
        [Validation(Required=false)]
        public SubmitAudioTo2DAvatarVideoTaskRequestVideoInfo VideoInfo { get; set; }
        public class SubmitAudioTo2DAvatarVideoTaskRequestVideoInfo : TeaModel {
            [NameInMap("AlphaFormat")]
            [Validation(Required=false)]
            public int? AlphaFormat { get; set; }

            [NameInMap("BackgroundImageUrl")]
            [Validation(Required=false)]
            public string BackgroundImageUrl { get; set; }

            [NameInMap("IsAlpha")]
            [Validation(Required=false)]
            public bool? IsAlpha { get; set; }

            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public int? Resolution { get; set; }

        }

    }

}
