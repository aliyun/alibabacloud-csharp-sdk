// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        [NameInMap("AdvanceDataPolicies")]
        [Validation(Required=false)]
        public List<ModifyBackupPolicyRequestAdvanceDataPolicies> AdvanceDataPolicies { get; set; }
        public class ModifyBackupPolicyRequestAdvanceDataPolicies : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            [NameInMap("FilterType")]
            [Validation(Required=false)]
            public string FilterType { get; set; }

            [NameInMap("FilterType-copy")]
            [Validation(Required=false)]
            public string FilterTypeCopy { get; set; }

            [NameInMap("FilterValue")]
            [Validation(Required=false)]
            public string FilterValue { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("RetentionType")]
            [Validation(Required=false)]
            public string RetentionType { get; set; }

            [NameInMap("RetentionValue")]
            [Validation(Required=false)]
            public string RetentionValue { get; set; }

            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

        }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("PreferredBackupWindowBegin")]
        [Validation(Required=false)]
        public string PreferredBackupWindowBegin { get; set; }

        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

    }

}
