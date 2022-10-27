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
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultCategory> Category { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultCategory : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultKeyword> Keyword { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultKeyword : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultLocation> Location { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultLocation : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            [NameInMap("Person")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultPerson> Person { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultPerson : TeaModel {
                [NameInMap("FaceUrl")]
                [Validation(Required=false)]
                public string FaceUrl { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultTime> Time { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultTime : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

        }

    }

}
