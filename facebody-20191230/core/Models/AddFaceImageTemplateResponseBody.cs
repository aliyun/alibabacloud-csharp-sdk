// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddFaceImageTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddFaceImageTemplateResponseBodyData Data { get; set; }
        public class AddFaceImageTemplateResponseBodyData : TeaModel {
            [NameInMap("FaceInfos")]
            [Validation(Required=false)]
            public List<AddFaceImageTemplateResponseBodyDataFaceInfos> FaceInfos { get; set; }
            public class AddFaceImageTemplateResponseBodyDataFaceInfos : TeaModel {
                [NameInMap("FaceRect")]
                [Validation(Required=false)]
                public AddFaceImageTemplateResponseBodyDataFaceInfosFaceRect FaceRect { get; set; }
                public class AddFaceImageTemplateResponseBodyDataFaceInfosFaceRect : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
