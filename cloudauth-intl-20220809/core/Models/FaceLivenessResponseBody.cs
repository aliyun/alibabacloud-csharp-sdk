// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceLivenessResponseBodyResult Result { get; set; }
        public class FaceLivenessResponseBodyResult : TeaModel {
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public FaceLivenessResponseBodyResultExtFaceInfo ExtFaceInfo { get; set; }
            public class FaceLivenessResponseBodyResultExtFaceInfo : TeaModel {
                [NameInMap("FaceAge")]
                [Validation(Required=false)]
                public int? FaceAge { get; set; }

                [NameInMap("FaceAttack")]
                [Validation(Required=false)]
                public string FaceAttack { get; set; }

                [NameInMap("FaceGender")]
                [Validation(Required=false)]
                public string FaceGender { get; set; }

                [NameInMap("FaceQualityScore")]
                [Validation(Required=false)]
                public double? FaceQualityScore { get; set; }

                [NameInMap("OcclusionResult")]
                [Validation(Required=false)]
                public string OcclusionResult { get; set; }

            }

            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
