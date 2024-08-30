// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetTrainingJobErrorInfoResponseBody : TeaModel {
        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public GetTrainingJobErrorInfoResponseBodyErrorInfo ErrorInfo { get; set; }
        public class GetTrainingJobErrorInfoResponseBodyErrorInfo : TeaModel {
            [NameInMap("AdditionalInfo")]
            [Validation(Required=false)]
            public string AdditionalInfo { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
