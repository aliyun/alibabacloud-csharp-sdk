// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeActionAdvanceRequest : TeaModel {
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("URLList")]
        [Validation(Required=false)]
        public List<RecognizeActionAdvanceRequestURLList> URLList { get; set; }
        public class RecognizeActionAdvanceRequestURLList : TeaModel {
            [NameInMap("URL")]
            [Validation(Required=false)]
            public Stream URLObject { get; set; }

            [NameInMap("imageData")]
            [Validation(Required=false)]
            public string ImageData { get; set; }

        }

        [NameInMap("VideoData")]
        [Validation(Required=false)]
        public string VideoData { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
