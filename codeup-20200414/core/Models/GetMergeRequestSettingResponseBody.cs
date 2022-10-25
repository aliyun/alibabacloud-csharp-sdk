// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetMergeRequestSettingResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMergeRequestSettingResponseBodyResult Result { get; set; }
        public class GetMergeRequestSettingResponseBodyResult : TeaModel {
            [NameInMap("IsEnableSmartCodeReview")]
            [Validation(Required=false)]
            public bool? IsEnableSmartCodeReview { get; set; }

            [NameInMap("MergeTypes")]
            [Validation(Required=false)]
            public List<string> MergeTypes { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
