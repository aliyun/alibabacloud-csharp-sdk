// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetImageTranslateResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetImageTranslateResponseData Data { get; set; }
        public class GetImageTranslateResponseData : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=true)]
            public string Url { get; set; }
            [NameInMap("Orc")]
            [Validation(Required=true)]
            public string Orc { get; set; }
            [NameInMap("PictureEditor")]
            [Validation(Required=true)]
            public string PictureEditor { get; set; }
        };

    }

}
