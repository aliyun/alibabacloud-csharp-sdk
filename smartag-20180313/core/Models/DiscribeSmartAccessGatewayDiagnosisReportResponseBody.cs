// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBody : TeaModel {
        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResult DiagnoseResult { get; set; }
        public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResult : TeaModel {
            [NameInMap("BoxType")]
            [Validation(Required=false)]
            public string BoxType { get; set; }
            [NameInMap("BoxVersion")]
            [Validation(Required=false)]
            public string BoxVersion { get; set; }
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetails> Details { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetails : TeaModel {
                public List<DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItems> Items { get; set; }
                public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItems : TeaModel {
                    public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsCN CN { get; set; }
                    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsCN : TeaModel {
                        [NameInMap("Advice")]
                        [Validation(Required=false)]
                        public List<string> Advice { get; set; }

                        [NameInMap("Details")]
                        [Validation(Required=false)]
                        public List<string> Details { get; set; }

                        [NameInMap("ItemLevel")]
                        [Validation(Required=false)]
                        public string ItemLevel { get; set; }

                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        [NameInMap("ItemType")]
                        [Validation(Required=false)]
                        public string ItemType { get; set; }

                    }
                    public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsEN EN { get; set; }
                    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsEN : TeaModel {
                        [NameInMap("Advice")]
                        [Validation(Required=false)]
                        public List<string> Advice { get; set; }

                        [NameInMap("Details")]
                        [Validation(Required=false)]
                        public List<string> Details { get; set; }

                        [NameInMap("ItemLevel")]
                        [Validation(Required=false)]
                        public string ItemLevel { get; set; }

                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        [NameInMap("ItemType")]
                        [Validation(Required=false)]
                        public string ItemType { get; set; }

                    }
                    public long? EndTime { get; set; }
                    public string ItemName { get; set; }
                    public string Level { get; set; }
                    public long? StartTime { get; set; }
                    public string Type { get; set; }
                }
                public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsStatistics Statistics { get; set; }
                public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsStatistics : TeaModel {
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public int? Error { get; set; }

                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public int? Info { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public int? Warning { get; set; }

                }
                public string Type { get; set; }
            }
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }
            [NameInMap("FinishedNumber")]
            [Validation(Required=false)]
            public int? FinishedNumber { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultLevel Level { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultLevel : TeaModel {
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public string Total { get; set; }

            }
            [NameInMap("MonitorVersion")]
            [Validation(Required=false)]
            public string MonitorVersion { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }
            [NameInMap("ReportSLSSuccess")]
            [Validation(Required=false)]
            public int? ReportSLSSuccess { get; set; }
            [NameInMap("SN")]
            [Validation(Required=false)]
            public string SN { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultStatistics Statistics { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultStatistics : TeaModel {
                [NameInMap("Error")]
                [Validation(Required=false)]
                public int? Error { get; set; }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public int? Info { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                [NameInMap("Warning")]
                [Validation(Required=false)]
                public int? Warning { get; set; }

            }
            [NameInMap("StoreType")]
            [Validation(Required=false)]
            public string StoreType { get; set; }
            [NameInMap("TotalNumber")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }
            [NameInMap("UId")]
            [Validation(Required=false)]
            public string UId { get; set; }
            [NameInMap("UserLevel")]
            [Validation(Required=false)]
            public string UserLevel { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
