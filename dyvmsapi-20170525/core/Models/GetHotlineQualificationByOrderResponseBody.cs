// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class GetHotlineQualificationByOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineQualificationByOrderResponseBodyData Data { get; set; }
        public class GetHotlineQualificationByOrderResponseBodyData : TeaModel {
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }
            [NameInMap("QualificationId")]
            [Validation(Required=false)]
            public string QualificationId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
