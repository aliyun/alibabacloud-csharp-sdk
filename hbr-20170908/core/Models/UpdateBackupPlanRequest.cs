// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateBackupPlanRequest : TeaModel {
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Dictionary<string, object> Detail { get; set; }

        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public OtsDetail OtsDetail { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<UpdateBackupPlanRequestRule> Rule { get; set; }
        public class UpdateBackupPlanRequestRule : TeaModel {
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            [NameInMap("DestinationRetention")]
            [Validation(Required=false)]
            public long? DestinationRetention { get; set; }

            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            [NameInMap("DoCopy")]
            [Validation(Required=false)]
            public bool? DoCopy { get; set; }

            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

        [NameInMap("UpdatePaths")]
        [Validation(Required=false)]
        public bool? UpdatePaths { get; set; }

        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
