// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIVideoTagResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoTagResult")]
        [Validation(Required=false)]
        public GetAIVideoTagResultResponseBodyVideoTagResult VideoTagResult { get; set; }
        public class GetAIVideoTagResultResponseBodyVideoTagResult : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultTime> Time { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultTime : TeaModel {
                public List<string> Times { get; set; }
                public string Tag { get; set; }
            }
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultKeyword> Keyword { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultKeyword : TeaModel {
                public List<string> Times { get; set; }
                public string Tag { get; set; }
            }
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultCategory> Category { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultCategory : TeaModel {
                public string Tag { get; set; }
            }
            [NameInMap("Person")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultPerson> Person { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultPerson : TeaModel {
                public string FaceUrl { get; set; }
                public List<string> Times { get; set; }
                public string Tag { get; set; }
            }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultLocation> Location { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultLocation : TeaModel {
                public List<string> Times { get; set; }
                public string Tag { get; set; }
            }
        };

    }

}
