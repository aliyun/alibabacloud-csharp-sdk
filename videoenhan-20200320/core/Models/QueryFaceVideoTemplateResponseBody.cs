// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class QueryFaceVideoTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceVideoTemplateResponseBodyData Data { get; set; }
        public class QueryFaceVideoTemplateResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<QueryFaceVideoTemplateResponseBodyDataElements> Elements { get; set; }
            public class QueryFaceVideoTemplateResponseBodyDataElements : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FaceInfos")]
                [Validation(Required=false)]
                public List<QueryFaceVideoTemplateResponseBodyDataElementsFaceInfos> FaceInfos { get; set; }
                public class QueryFaceVideoTemplateResponseBodyDataElementsFaceInfos : TeaModel {
                    [NameInMap("TemplateFaceID")]
                    [Validation(Required=false)]
                    public string TemplateFaceID { get; set; }

                    [NameInMap("TemplateFaceURL")]
                    [Validation(Required=false)]
                    public string TemplateFaceURL { get; set; }

                }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("TemplateURL")]
                [Validation(Required=false)]
                public string TemplateURL { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
