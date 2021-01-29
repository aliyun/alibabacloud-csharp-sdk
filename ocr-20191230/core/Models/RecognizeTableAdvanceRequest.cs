// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTableAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public int? ImageType { get; set; }

        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("UseFinanceModel")]
        [Validation(Required=false)]
        public bool? UseFinanceModel { get; set; }

        [NameInMap("AssureDirection")]
        [Validation(Required=false)]
        public bool? AssureDirection { get; set; }

        [NameInMap("HasLine")]
        [Validation(Required=false)]
        public bool? HasLine { get; set; }

        [NameInMap("SkipDetection")]
        [Validation(Required=false)]
        public bool? SkipDetection { get; set; }

    }

}
