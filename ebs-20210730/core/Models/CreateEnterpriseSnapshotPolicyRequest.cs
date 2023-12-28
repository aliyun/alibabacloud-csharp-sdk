// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateEnterpriseSnapshotPolicyRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
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
        public CreateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

        }

        [NameInMap("SpecialRetainRules")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
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
        public CreateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
            [NameInMap("EnableImmediateAccess")]
            [Validation(Required=false)]
            public bool? EnableImmediateAccess { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEnterpriseSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
