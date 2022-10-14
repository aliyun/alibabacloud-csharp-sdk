// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateGeneralRequest : TeaModel {
        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        [NameInMap("SourceText")]
        [Validation(Required=false)]
        public string SourceText { get; set; }

        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

    }

}
