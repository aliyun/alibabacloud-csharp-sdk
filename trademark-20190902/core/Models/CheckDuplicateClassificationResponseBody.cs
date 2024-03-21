// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class CheckDuplicateClassificationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckDuplicateClassificationResponseBodyData Data { get; set; }
        public class CheckDuplicateClassificationResponseBodyData : TeaModel {
            [NameInMap("DuplicateSecondaryClassification")]
            [Validation(Required=false)]
            public CheckDuplicateClassificationResponseBodyDataDuplicateSecondaryClassification DuplicateSecondaryClassification { get; set; }
            public class CheckDuplicateClassificationResponseBodyDataDuplicateSecondaryClassification : TeaModel {
                [NameInMap("SecondaryClassification")]
                [Validation(Required=false)]
                public List<string> SecondaryClassification { get; set; }

            }

            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
