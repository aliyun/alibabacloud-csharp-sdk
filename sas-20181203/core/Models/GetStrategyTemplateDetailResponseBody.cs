// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetStrategyTemplateDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStrategyTemplateDetailResponseBodyData Data { get; set; }
        public class GetStrategyTemplateDetailResponseBodyData : TeaModel {
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public GetStrategyTemplateDetailResponseBodyDataAlarmDetail AlarmDetail { get; set; }
            public class GetStrategyTemplateDetailResponseBodyDataAlarmDetail : TeaModel {
                [NameInMap("Baseline")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaseline Baseline { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaseline : TeaModel {
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaselineItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaselineItem : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                [NameInMap("MaliciousFile")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFile MaliciousFile { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFile : TeaModel {
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFileItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFileItem : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                [NameInMap("Vul")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailVul Vul { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailVul : TeaModel {
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailVulItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailVulItem : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

            }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            [NameInMap("MaliciousImage")]
            [Validation(Required=false)]
            public bool? MaliciousImage { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public List<string> Namespace { get; set; }

            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            [NameInMap("StrategyTemplateId")]
            [Validation(Required=false)]
            public long? StrategyTemplateId { get; set; }

            [NameInMap("UnScanedImage")]
            [Validation(Required=false)]
            public bool? UnScanedImage { get; set; }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
