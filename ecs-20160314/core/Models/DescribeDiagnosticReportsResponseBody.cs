// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeDiagnosticReportsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Reports")]
        [Validation(Required=false)]
        public DescribeDiagnosticReportsResponseBodyReports Reports { get; set; }
        public class DescribeDiagnosticReportsResponseBodyReports : TeaModel {
            [NameInMap("Report")]
            [Validation(Required=false)]
            public List<DescribeDiagnosticReportsResponseBodyReportsReport> Report { get; set; }
            public class DescribeDiagnosticReportsResponseBodyReportsReport : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DiagnosticCategory")]
                [Validation(Required=false)]
                public string DiagnosticCategory { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                [NameInMap("InvokeSystem")]
                [Validation(Required=false)]
                public string InvokeSystem { get; set; }

                [NameInMap("IssueCategoryId")]
                [Validation(Required=false)]
                public string IssueCategoryId { get; set; }

                [NameInMap("Issues")]
                [Validation(Required=false)]
                public DescribeDiagnosticReportsResponseBodyReportsReportIssues Issues { get; set; }
                public class DescribeDiagnosticReportsResponseBodyReportsReportIssues : TeaModel {
                    [NameInMap("Issue")]
                    [Validation(Required=false)]
                    public List<DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssue> Issue { get; set; }
                    public class DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssue : TeaModel {
                        [NameInMap("IssueCategory")]
                        [Validation(Required=false)]
                        public string IssueCategory { get; set; }

                        [NameInMap("IssueCode")]
                        [Validation(Required=false)]
                        public string IssueCode { get; set; }

                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        [NameInMap("OccurrenceTime")]
                        [Validation(Required=false)]
                        public string OccurrenceTime { get; set; }

                        [NameInMap("RecommendedActions")]
                        [Validation(Required=false)]
                        public DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActions RecommendedActions { get; set; }
                        public class DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActions : TeaModel {
                            [NameInMap("RecommendedAction")]
                            [Validation(Required=false)]
                            public List<DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActionsRecommendedAction> RecommendedAction { get; set; }
                            public class DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActionsRecommendedAction : TeaModel {
                                [NameInMap("ActionCode")]
                                [Validation(Required=false)]
                                public string ActionCode { get; set; }

                                [NameInMap("Parameters")]
                                [Validation(Required=false)]
                                public DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActionsRecommendedActionParameters Parameters { get; set; }
                                public class DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActionsRecommendedActionParameters : TeaModel {
                                    [NameInMap("Parameter")]
                                    [Validation(Required=false)]
                                    public List<DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActionsRecommendedActionParametersParameter> Parameter { get; set; }
                                    public class DescribeDiagnosticReportsResponseBodyReportsReportIssuesIssueRecommendedActionsRecommendedActionParametersParameter : TeaModel {
                                        [NameInMap("Key")]
                                        [Validation(Required=false)]
                                        public string Key { get; set; }

                                        [NameInMap("Value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                            }

                        }

                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public DescribeDiagnosticReportsResponseBodyReportsReportItems Items { get; set; }
                public class DescribeDiagnosticReportsResponseBodyReportsReportItems : TeaModel {
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<DescribeDiagnosticReportsResponseBodyReportsReportItemsItem> Item { get; set; }
                    public class DescribeDiagnosticReportsResponseBodyReportsReportItemsItem : TeaModel {
                        [NameInMap("ItemCategory")]
                        [Validation(Required=false)]
                        public string ItemCategory { get; set; }

                        [NameInMap("ItemCode")]
                        [Validation(Required=false)]
                        public string ItemCode { get; set; }

                        [NameInMap("ItemDatas")]
                        [Validation(Required=false)]
                        public DescribeDiagnosticReportsResponseBodyReportsReportItemsItemItemDatas ItemDatas { get; set; }
                        public class DescribeDiagnosticReportsResponseBodyReportsReportItemsItemItemDatas : TeaModel {
                            [NameInMap("ItemData")]
                            [Validation(Required=false)]
                            public List<DescribeDiagnosticReportsResponseBodyReportsReportItemsItemItemDatasItemData> ItemData { get; set; }
                            public class DescribeDiagnosticReportsResponseBodyReportsReportItemsItemItemDatasItemData : TeaModel {
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        [NameInMap("OccurrenceTime")]
                        [Validation(Required=false)]
                        public string OccurrenceTime { get; set; }

                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("OfflineDiagReportStatus")]
                [Validation(Required=false)]
                public string OfflineDiagReportStatus { get; set; }

                [NameInMap("PePassword")]
                [Validation(Required=false)]
                public string PePassword { get; set; }

                [NameInMap("RecentEvents")]
                [Validation(Required=false)]
                public DescribeDiagnosticReportsResponseBodyReportsReportRecentEvents RecentEvents { get; set; }
                public class DescribeDiagnosticReportsResponseBodyReportsReportRecentEvents : TeaModel {
                    [NameInMap("RecentEvent")]
                    [Validation(Required=false)]
                    public List<DescribeDiagnosticReportsResponseBodyReportsReportRecentEventsRecentEvent> RecentEvent { get; set; }
                    public class DescribeDiagnosticReportsResponseBodyReportsReportRecentEventsRecentEvent : TeaModel {
                        [NameInMap("EventID")]
                        [Validation(Required=false)]
                        public string EventID { get; set; }

                        [NameInMap("EventName")]
                        [Validation(Required=false)]
                        public string EventName { get; set; }

                        [NameInMap("PublishTime")]
                        [Validation(Required=false)]
                        public string PublishTime { get; set; }

                    }

                }

                [NameInMap("ReportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
