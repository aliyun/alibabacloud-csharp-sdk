// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class ParseFaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ParseFaceResponseBodyData Data { get; set; }
        public class ParseFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ParseFaceResponseBodyDataElements> Elements { get; set; }
            public class ParseFaceResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("OriginImageURL")]
            [Validation(Required=false)]
            public string OriginImageURL { get; set; }
        };

    }

}
