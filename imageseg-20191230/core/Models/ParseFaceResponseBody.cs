// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class ParseFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ParseFaceResponseBodyData Data { get; set; }
        public class ParseFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ParseFaceResponseBodyDataElements> Elements { get; set; }
            public class ParseFaceResponseBodyDataElements : TeaModel {
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("OriginImageURL")]
            [Validation(Required=false)]
            public string OriginImageURL { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
