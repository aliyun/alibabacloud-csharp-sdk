// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class AddFaceVideoTemplateResponseBody : TeaModel {
        [NameInMap("Date")]
        [Validation(Required=false)]
        public AddFaceVideoTemplateResponseBodyDate Date { get; set; }
        public class AddFaceVideoTemplateResponseBodyDate : TeaModel {
            [NameInMap("FaceInfos")]
            [Validation(Required=false)]
            public List<AddFaceVideoTemplateResponseBodyDateFaceInfos> FaceInfos { get; set; }
            public class AddFaceVideoTemplateResponseBodyDateFaceInfos : TeaModel {
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

            [NameInMap("TransResult")]
            [Validation(Required=false)]
            public string TransResult { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
