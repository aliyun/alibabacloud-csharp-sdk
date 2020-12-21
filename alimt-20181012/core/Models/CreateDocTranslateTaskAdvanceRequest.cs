// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class CreateDocTranslateTaskAdvanceRequest : TeaModel {
        [NameInMap("FileUrlObject")]
        [Validation(Required=true)]
        public Stream FileUrlObject { get; set; }

        [NameInMap("SourceLanguage")]
        [Validation(Required=true)]
        public string SourceLanguage { get; set; }

        [NameInMap("TargetLanguage")]
        [Validation(Required=true)]
        public string TargetLanguage { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
