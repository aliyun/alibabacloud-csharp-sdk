// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateRequest : TeaModel {
        [NameInMap("FormatType")]
        [Validation(Required=true)]
        public string FormatType { get; set; }

        [NameInMap("TargetLanguage")]
        [Validation(Required=true)]
        public string TargetLanguage { get; set; }

        [NameInMap("SourceLanguage")]
        [Validation(Required=true)]
        public string SourceLanguage { get; set; }

        [NameInMap("SourceText")]
        [Validation(Required=true)]
        public string SourceText { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=true)]
        public string Scene { get; set; }

    }

}
