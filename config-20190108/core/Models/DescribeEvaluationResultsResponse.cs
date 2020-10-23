// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeEvaluationResultsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("EvaluationResults")]
        [Validation(Required=true)]
        public DescribeEvaluationResultsResponseEvaluationResults EvaluationResults { get; set; }
        public class DescribeEvaluationResultsResponseEvaluationResults : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("EvaluationResultList")]
            [Validation(Required=true)]
            public List<DescribeEvaluationResultsResponseEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class DescribeEvaluationResultsResponseEvaluationResultsEvaluationResultList : TeaModel {
                public string Annotation { get; set; }
                public string ComplianceType { get; set; }
                public long ConfigRuleInvokedTimestamp { get; set; }
                public string InvokingEventMessageType { get; set; }
                public long ResultRecordedTimestamp { get; set; }
                public int? RiskLevel { get; set; }
                public DescribeEvaluationResultsResponseEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class DescribeEvaluationResultsResponseEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    [NameInMap("OrderingTimestamp")]
                    [Validation(Required=true)]
                    public long OrderingTimestamp { get; set; }

                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=true)]
                    public DescribeEvaluationResultsResponseEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class DescribeEvaluationResultsResponseEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=true)]
                        public string ConfigRuleArn { get; set; }
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=true)]
                        public string ConfigRuleId { get; set; }
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=true)]
                        public string ConfigRuleName { get; set; }
                        [NameInMap("ResourceId")]
                        [Validation(Required=true)]
                        public string ResourceId { get; set; }
                        [NameInMap("ResourceType")]
                        [Validation(Required=true)]
                        public string ResourceType { get; set; }
                        [NameInMap("RegionId")]
                        [Validation(Required=true)]
                        public string RegionId { get; set; }
                    };

                }
            }
        };

    }

}
