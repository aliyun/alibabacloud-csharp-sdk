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

            /// <summary>
            /// <b>Example:</b>
            /// <para>6cd509ea-54fa-4730-8e9d-c94cadcda048</para>
            /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>F61182AE-515B-5B0A-A877-1C9AE908FF15</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
