// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeEvaluationResultsResponseBody : TeaModel {
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public DescribeEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class DescribeEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<DescribeEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class DescribeEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                public string Annotation { get; set; }
                public string ComplianceType { get; set; }
                public long? ConfigRuleInvokedTimestamp { get; set; }
                public DescribeEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class DescribeEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public DescribeEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class DescribeEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }
                    };

                    [NameInMap("OrderingTimestamp")]
                    [Validation(Required=false)]
                    public long? OrderingTimestamp { get; set; }

                }
                public string InvokingEventMessageType { get; set; }
                public bool? RemediationEnabled { get; set; }
                public long? ResultRecordedTimestamp { get; set; }
                public int? RiskLevel { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
