// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetImageTranslateRequest : TeaModel {
        [NameInMap("Url")]
        [Validation(Required=true)]
        public string Url { get; set; }

        [NameInMap("SourceLanguage")]
        [Validation(Required=true)]
        public string SourceLanguage { get; set; }

        [NameInMap("TargetLanguage")]
        [Validation(Required=true)]
        public string TargetLanguage { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

    }

}
