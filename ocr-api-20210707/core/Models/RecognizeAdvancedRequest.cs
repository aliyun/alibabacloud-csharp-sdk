// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeAdvancedRequest : TeaModel {
        [NameInMap("NeedRotate")]
        [Validation(Required=false)]
        public bool? NeedRotate { get; set; }

        [NameInMap("NeedSortPage")]
        [Validation(Required=false)]
        public bool? NeedSortPage { get; set; }

        [NameInMap("NoStamp")]
        [Validation(Required=false)]
        public bool? NoStamp { get; set; }

        [NameInMap("OutputCharInfo")]
        [Validation(Required=false)]
        public bool? OutputCharInfo { get; set; }

        [NameInMap("OutputFigure")]
        [Validation(Required=false)]
        public bool? OutputFigure { get; set; }

        [NameInMap("OutputTable")]
        [Validation(Required=false)]
        public bool? OutputTable { get; set; }

        [NameInMap("Paragraph")]
        [Validation(Required=false)]
        public bool? Paragraph { get; set; }

        [NameInMap("Row")]
        [Validation(Required=false)]
        public bool? Row { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
