// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpDingtalkSubConfig : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("EventAesKey")]
        [Validation(Required=false)]
        public string EventAesKey { get; set; }

        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        [NameInMap("EventVerifyToken")]
        [Validation(Required=false)]
        public string EventVerifyToken { get; set; }

        [NameInMap("Exclusive")]
        [Validation(Required=false)]
        public bool? Exclusive { get; set; }

        [NameInMap("RedirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

    }

}
