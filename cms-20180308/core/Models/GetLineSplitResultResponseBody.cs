// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class GetLineSplitResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public GetLineSplitResultResponseBodyResource Resource { get; set; }
        public class GetLineSplitResultResponseBodyResource : TeaModel {
            [NameInMap("AdditionalRegex")]
            [Validation(Required=false)]
            public string AdditionalRegex { get; set; }

            [NameInMap("EndSplitSymbol")]
            [Validation(Required=false)]
            public string EndSplitSymbol { get; set; }

            [NameInMap("Regex")]
            [Validation(Required=false)]
            public string Regex { get; set; }

            [NameInMap("RegexSplitResult")]
            [Validation(Required=false)]
            public List<string> RegexSplitResult { get; set; }

            [NameInMap("StartSplitSymbol")]
            [Validation(Required=false)]
            public string StartSplitSymbol { get; set; }

            [NameInMap("StartSplitSymbolIndex")]
            [Validation(Required=false)]
            public long? StartSplitSymbolIndex { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
