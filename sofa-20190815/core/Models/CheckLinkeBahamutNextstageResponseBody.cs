// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeBahamutNextstageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckLinkeBahamutNextstageResponseBodyResult Result { get; set; }
        public class CheckLinkeBahamutNextstageResponseBodyResult : TeaModel {
            [NameInMap("BatchGuardCheckResult")]
            [Validation(Required=false)]
            public CheckLinkeBahamutNextstageResponseBodyResultBatchGuardCheckResult BatchGuardCheckResult { get; set; }
            public class CheckLinkeBahamutNextstageResponseBodyResultBatchGuardCheckResult : TeaModel {
                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public long? PassCount { get; set; }

                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public long? FailCount { get; set; }

                [NameInMap("GuardCheckResultList")]
                [Validation(Required=false)]
                public List<CheckLinkeBahamutNextstageResponseBodyResultBatchGuardCheckResultGuardCheckResultList> GuardCheckResultList { get; set; }
                public class CheckLinkeBahamutNextstageResponseBodyResultBatchGuardCheckResultGuardCheckResultList : TeaModel {
                    [NameInMap("Pass")]
                    [Validation(Required=false)]
                    public bool? Pass { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("CheckResults")]
                    [Validation(Required=false)]
                    public List<CheckLinkeBahamutNextstageResponseBodyResultBatchGuardCheckResultGuardCheckResultListCheckResults> CheckResults { get; set; }
                    public class CheckLinkeBahamutNextstageResponseBodyResultBatchGuardCheckResultGuardCheckResultListCheckResults : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("RuleKey")]
                        [Validation(Required=false)]
                        public string RuleKey { get; set; }

                        [NameInMap("Pass")]
                        [Validation(Required=false)]
                        public bool? Pass { get; set; }

                        [NameInMap("Solution")]
                        [Validation(Required=false)]
                        public string Solution { get; set; }

                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }
            [NameInMap("WarnContent")]
            [Validation(Required=false)]
            public List<string> WarnContent { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<string> Content { get; set; }
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }
        };

    }

}
