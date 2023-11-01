// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SubmitAvatarVideoTaskRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public SubmitAvatarVideoTaskRequestApp App { get; set; }
        public class SubmitAvatarVideoTaskRequestApp : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

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

        [NameInMap("VideoParams")]
        [Validation(Required=false)]
        public string VideoParams { get; set; }

    }

}
