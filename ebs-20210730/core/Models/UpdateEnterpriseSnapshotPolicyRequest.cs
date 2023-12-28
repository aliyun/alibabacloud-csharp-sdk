// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class UpdateEnterpriseSnapshotPolicyRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RetainDays")]
                [Validation(Required=false)]
                public int? RetainDays { get; set; }

            }

        }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            [NameInMap("TimeInterval")]
            [Validation(Required=false)]
            public int? TimeInterval { get; set; }

            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

        }

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

        }

        [NameInMap("SpecialRetainRules")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
                [NameInMap("SpecialPeriodUnit")]
                [Validation(Required=false)]
                public string SpecialPeriodUnit { get; set; }

                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

        }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("StorageRule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
            [NameInMap("EnableImmediateAccess")]
            [Validation(Required=false)]
            public bool? EnableImmediateAccess { get; set; }

        }

    }

}
