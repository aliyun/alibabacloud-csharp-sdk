// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOpaStrategyNewRequest : TeaModel {
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public CreateOpaStrategyNewRequestAlarmDetail AlarmDetail { get; set; }
        public class CreateOpaStrategyNewRequestAlarmDetail : TeaModel {
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public CreateOpaStrategyNewRequestAlarmDetailBaseline Baseline { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailBaseline : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailBaselineItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailBaselineItem : TeaModel {
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
            public CreateOpaStrategyNewRequestAlarmDetailMaliciousFile MaliciousFile { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailMaliciousFile : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailMaliciousFileItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailMaliciousFileItem : TeaModel {
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
            public CreateOpaStrategyNewRequestAlarmDetailVul Vul { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailVul : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailVulItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailVulItem : TeaModel {
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

        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<CreateOpaStrategyNewRequestScopes> Scopes { get; set; }
        public class CreateOpaStrategyNewRequestScopes : TeaModel {
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

}
