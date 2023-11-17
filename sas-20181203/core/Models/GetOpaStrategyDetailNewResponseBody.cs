// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaStrategyDetailNewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOpaStrategyDetailNewResponseBodyData Data { get; set; }
        public class GetOpaStrategyDetailNewResponseBodyData : TeaModel {
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public GetOpaStrategyDetailNewResponseBodyDataAlarmDetail AlarmDetail { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetail : TeaModel {
                [NameInMap("Baseline")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline Baseline { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline : TeaModel {
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaselineItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaselineItem : TeaModel {
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
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile MaliciousFile { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile : TeaModel {
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFileItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFileItem : TeaModel {
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
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul Vul { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul : TeaModel {
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem : TeaModel {
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

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            [NameInMap("MaliciousImage")]
            [Validation(Required=false)]
            public bool? MaliciousImage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<GetOpaStrategyDetailNewResponseBodyDataScopes> Scopes { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataScopes : TeaModel {
                [NameInMap("AckPolicyInstanceId")]
                [Validation(Required=false)]
                public string AckPolicyInstanceId { get; set; }

                [NameInMap("AllNamespace")]
                [Validation(Required=false)]
                public int? AllNamespace { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<string> NamespaceList { get; set; }

            }

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

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
