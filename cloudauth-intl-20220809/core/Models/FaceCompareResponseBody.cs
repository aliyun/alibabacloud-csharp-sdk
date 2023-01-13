// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCompareResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceCompareResponseBodyResult Result { get; set; }
        public class FaceCompareResponseBodyResult : TeaModel {
            [NameInMap("FaceComparisonScore")]
            [Validation(Required=false)]
            public double? FaceComparisonScore { get; set; }

            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
