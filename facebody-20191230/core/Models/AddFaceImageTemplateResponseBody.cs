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
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
