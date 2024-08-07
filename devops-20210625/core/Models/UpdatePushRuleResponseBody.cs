// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdatePushRuleResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdatePushRuleResponseBodyResult Result { get; set; }
        public class UpdatePushRuleResponseBodyResult : TeaModel {
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ruleInfos")]
            [Validation(Required=false)]
            public List<UpdatePushRuleResponseBodyResultRuleInfos> RuleInfos { get; set; }
            public class UpdatePushRuleResponseBodyResultRuleInfos : TeaModel {
                [NameInMap("checkerName")]
                [Validation(Required=false)]
                public string CheckerName { get; set; }

                [NameInMap("checkerType")]
                [Validation(Required=false)]
                public string CheckerType { get; set; }

                [NameInMap("extraMessage")]
                [Validation(Required=false)]
                public string ExtraMessage { get; set; }

                [NameInMap("fileRuleRegexes")]
                [Validation(Required=false)]
                public List<string> FileRuleRegexes { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
