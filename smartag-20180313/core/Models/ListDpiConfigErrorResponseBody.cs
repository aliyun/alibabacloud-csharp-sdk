// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiConfigErrorResponseBody : TeaModel {
        [NameInMap("DpiConfigError")]
        [Validation(Required=false)]
        public List<ListDpiConfigErrorResponseBodyDpiConfigError> DpiConfigError { get; set; }
        public class ListDpiConfigErrorResponseBodyDpiConfigError : TeaModel {
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            [NameInMap("RuleConfigErrorList")]
            [Validation(Required=false)]
            public List<ListDpiConfigErrorResponseBodyDpiConfigErrorRuleConfigErrorList> RuleConfigErrorList { get; set; }
            public class ListDpiConfigErrorResponseBodyDpiConfigErrorRuleConfigErrorList : TeaModel {
                [NameInMap("DpiGroupIds")]
                [Validation(Required=false)]
                public List<string> DpiGroupIds { get; set; }

                [NameInMap("DpiSignatureIds")]
                [Validation(Required=false)]
                public List<string> DpiSignatureIds { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

            [NameInMap("SN")]
            [Validation(Required=false)]
            public string SN { get; set; }

            [NameInMap("SmartAGId")]
            [Validation(Required=false)]
            public string SmartAGId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
