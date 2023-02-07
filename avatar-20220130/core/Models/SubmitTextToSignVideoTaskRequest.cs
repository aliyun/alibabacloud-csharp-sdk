// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SubmitTextToSignVideoTaskRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public SubmitTextToSignVideoTaskRequestApp App { get; set; }
        public class SubmitTextToSignVideoTaskRequestApp : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

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
        public SubmitTextToSignVideoTaskRequestVideoInfo VideoInfo { get; set; }
        public class SubmitTextToSignVideoTaskRequestVideoInfo : TeaModel {
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
