// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SubmitTextTo2DAvatarVideoTaskShrinkRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string AppShrink { get; set; }

        [NameInMap("AudioInfo")]
        [Validation(Required=false)]
        public string AudioInfoShrink { get; set; }

        [NameInMap("AvatarInfo")]
        [Validation(Required=false)]
        public string AvatarInfoShrink { get; set; }

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

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("VideoInfo")]
        [Validation(Required=false)]
        public string VideoInfoShrink { get; set; }

    }

}
