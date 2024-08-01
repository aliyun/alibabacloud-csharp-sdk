// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgQueryModelTrainStatusResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public Personalizedtxt2imgQueryModelTrainStatusResponseBodyData Data { get; set; }
        public class Personalizedtxt2imgQueryModelTrainStatusResponseBodyData : TeaModel {
            [NameInMap("modelTrainStatus")]
            [Validation(Required=false)]
            public string ModelTrainStatus { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
