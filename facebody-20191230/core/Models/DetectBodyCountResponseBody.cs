// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectBodyCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectBodyCountResponseBodyData Data { get; set; }
        public class DetectBodyCountResponseBodyData : TeaModel {
            [NameInMap("PersonNumber")]
            [Validation(Required=false)]
            public int? PersonNumber { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
