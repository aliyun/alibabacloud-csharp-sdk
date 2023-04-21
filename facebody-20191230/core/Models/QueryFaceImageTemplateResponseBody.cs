// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class QueryFaceImageTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceImageTemplateResponseBodyData Data { get; set; }
        public class QueryFaceImageTemplateResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<QueryFaceImageTemplateResponseBodyDataElements> Elements { get; set; }
            public class QueryFaceImageTemplateResponseBodyDataElements : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FaceInfos")]
                [Validation(Required=false)]
                public List<QueryFaceImageTemplateResponseBodyDataElementsFaceInfos> FaceInfos { get; set; }
                public class QueryFaceImageTemplateResponseBodyDataElementsFaceInfos : TeaModel {
                    [NameInMap("FaceRect")]
                    [Validation(Required=false)]
                    public QueryFaceImageTemplateResponseBodyDataElementsFaceInfosFaceRect FaceRect { get; set; }
                    public class QueryFaceImageTemplateResponseBodyDataElementsFaceInfosFaceRect : TeaModel {
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public string X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public string Y { get; set; }

                    }

                    [NameInMap("TemplateFaceID")]
                    [Validation(Required=false)]
                    public string TemplateFaceID { get; set; }

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
