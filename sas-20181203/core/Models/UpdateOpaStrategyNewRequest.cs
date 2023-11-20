// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOpaStrategyNewRequest : TeaModel {
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public UpdateOpaStrategyNewRequestAlarmDetail AlarmDetail { get; set; }
        public class UpdateOpaStrategyNewRequestAlarmDetail : TeaModel {
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public UpdateOpaStrategyNewRequestAlarmDetailBaseline Baseline { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailBaseline : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailBaselineItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailBaselineItem : TeaModel {
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
            public UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile MaliciousFile { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem : TeaModel {
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
            public UpdateOpaStrategyNewRequestAlarmDetailVul Vul { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailVul : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailVulItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailVulItem : TeaModel {
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
        public List<UpdateOpaStrategyNewRequestScopes> Scopes { get; set; }
        public class UpdateOpaStrategyNewRequestScopes : TeaModel {
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
