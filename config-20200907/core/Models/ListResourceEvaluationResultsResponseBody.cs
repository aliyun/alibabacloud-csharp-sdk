// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceEvaluationResultsResponseBody : TeaModel {
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListResourceEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListResourceEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                public string Annotation { get; set; }
                public string ComplianceType { get; set; }
                public long? ConfigRuleInvokedTimestamp { get; set; }
                public ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }
                        [NameInMap("IgnoreDate")]
                        [Validation(Required=false)]
                        public string IgnoreDate { get; set; }
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
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
