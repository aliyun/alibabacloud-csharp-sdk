// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetadataResponseBody : TeaModel {
        [NameInMap("EvaluationMetadata")]
        [Validation(Required=false)]
        public List<ListEvaluationMetadataResponseBodyEvaluationMetadata> EvaluationMetadata { get; set; }
        public class ListEvaluationMetadataResponseBodyEvaluationMetadata : TeaModel {
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadata> Metadata { get; set; }
            public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadata : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("RecommendationLevel")]
                [Validation(Required=false)]
                public string RecommendationLevel { get; set; }

                [NameInMap("RemediationMetadata")]
                [Validation(Required=false)]
                public ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadata RemediationMetadata { get; set; }
                public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadata : TeaModel {
                    [NameInMap("Remediation")]
                    [Validation(Required=false)]
                    public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediation> Remediation { get; set; }
                    public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediation : TeaModel {
                        [NameInMap("Actions")]
                        [Validation(Required=false)]
                        public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActions> Actions { get; set; }
                        public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActions : TeaModel {
                            [NameInMap("Classification")]
                            [Validation(Required=false)]
                            public string Classification { get; set; }

                            [NameInMap("CostDescription")]
                            [Validation(Required=false)]
                            public string CostDescription { get; set; }

                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            [NameInMap("Guidance")]
                            [Validation(Required=false)]
                            public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActionsGuidance> Guidance { get; set; }
                            public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActionsGuidance : TeaModel {
                                [NameInMap("ButtonName")]
                                [Validation(Required=false)]
                                public string ButtonName { get; set; }

                                [NameInMap("ButtonRef")]
                                [Validation(Required=false)]
                                public string ButtonRef { get; set; }

                                [NameInMap("Content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("Title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            [NameInMap("Notice")]
                            [Validation(Required=false)]
                            public string Notice { get; set; }

                            [NameInMap("Suggestion")]
                            [Validation(Required=false)]
                            public string Suggestion { get; set; }

                        }

                        [NameInMap("RemediationType")]
                        [Validation(Required=false)]
                        public string RemediationType { get; set; }

                    }

                }

                [NameInMap("ResourceMetadata")]
                [Validation(Required=false)]
                public ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadata ResourceMetadata { get; set; }
                public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadata : TeaModel {
                    [NameInMap("ResourcePropertyMetadata")]
                    [Validation(Required=false)]
                    public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadataResourcePropertyMetadata> ResourcePropertyMetadata { get; set; }
                    public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadataResourcePropertyMetadata : TeaModel {
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        [NameInMap("PropertyName")]
                        [Validation(Required=false)]
                        public string PropertyName { get; set; }

                        [NameInMap("PropertyType")]
                        [Validation(Required=false)]
                        public string PropertyType { get; set; }

                    }

                }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("Stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
