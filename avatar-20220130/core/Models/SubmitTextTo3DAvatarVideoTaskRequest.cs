// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SubmitTextTo3DAvatarVideoTaskRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public SubmitTextTo3DAvatarVideoTaskRequestApp App { get; set; }
        public class SubmitTextTo3DAvatarVideoTaskRequestApp : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

        }

        [NameInMap("AvatarInfo")]
        [Validation(Required=false)]
        public SubmitTextTo3DAvatarVideoTaskRequestAvatarInfo AvatarInfo { get; set; }
        public class SubmitTextTo3DAvatarVideoTaskRequestAvatarInfo : TeaModel {
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public int? Angle { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Locate")]
            [Validation(Required=false)]
            public int? Locate { get; set; }

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
        public SubmitTextTo3DAvatarVideoTaskRequestVideoInfo VideoInfo { get; set; }
        public class SubmitTextTo3DAvatarVideoTaskRequestVideoInfo : TeaModel {
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
