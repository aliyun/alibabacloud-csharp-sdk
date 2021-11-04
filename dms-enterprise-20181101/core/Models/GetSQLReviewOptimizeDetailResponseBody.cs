// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewOptimizeDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("OptimizeDetail")]
        [Validation(Required=false)]
        public GetSQLReviewOptimizeDetailResponseBodyOptimizeDetail OptimizeDetail { get; set; }
        public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetail : TeaModel {
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public int? InstanceId { get; set; }
            [NameInMap("QualityResult")]
            [Validation(Required=false)]
            public GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResult QualityResult { get; set; }
            public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResult : TeaModel {
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("OccurError")]
                [Validation(Required=false)]
                public bool? OccurError { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResults> Results { get; set; }
                public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResults : TeaModel {
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    [NameInMap("Feedback")]
                    [Validation(Required=false)]
                    public string Feedback { get; set; }

                    [NameInMap("Messages")]
                    [Validation(Required=false)]
                    public List<string> Messages { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    [NameInMap("Scripts")]
                    [Validation(Required=false)]
                    public List<GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResultsScripts> Scripts { get; set; }
                    public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResultsScripts : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("OpType")]
                        [Validation(Required=false)]
                        public string OpType { get; set; }

                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                }

            }
            [NameInMap("QueryKey")]
            [Validation(Required=false)]
            public string QueryKey { get; set; }
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
