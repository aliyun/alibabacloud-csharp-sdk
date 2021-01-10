// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDTXRecoveryInitiatorsRequest : TeaModel {
        [NameInMap("ActionMode")]
        [Validation(Required=false)]
        public long? ActionMode { get; set; }

        [NameInMap("ActivityMode")]
        [Validation(Required=false)]
        public long? ActivityMode { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsAsyn")]
        [Validation(Required=false)]
        public bool? IsAsyn { get; set; }

        [NameInMap("IsLoadTest")]
        [Validation(Required=false)]
        public bool? IsLoadTest { get; set; }

        [NameInMap("IsMix")]
        [Validation(Required=false)]
        public bool? IsMix { get; set; }

        [NameInMap("RecoveryLimit")]
        [Validation(Required=false)]
        public long? RecoveryLimit { get; set; }

        [NameInMap("RecoveryThreadNum")]
        [Validation(Required=false)]
        public long? RecoveryThreadNum { get; set; }

        [NameInMap("SplitMode")]
        [Validation(Required=false)]
        public string SplitMode { get; set; }

        [NameInMap("SplitRuleJsonStr")]
        [Validation(Required=false)]
        public string SplitRuleJsonStr { get; set; }

        [NameInMap("RecoveryDatasources")]
        [Validation(Required=false)]
        public List<CreateDTXRecoveryInitiatorsRequestRecoveryDatasources> RecoveryDatasources { get; set; }
        public class CreateDTXRecoveryInitiatorsRequestRecoveryDatasources : TeaModel {
            [NameInMap("IsLdc")]
            [Validation(Required=false)]
            public bool? IsLdc { get; set; }

            [NameInMap("DsIndexEnd")]
            [Validation(Required=false)]
            public long? DsIndexEnd { get; set; }

            [NameInMap("ActionTableNameFormat")]
            [Validation(Required=false)]
            public string ActionTableNameFormat { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IsLocalDs")]
            [Validation(Required=false)]
            public bool? IsLocalDs { get; set; }

            [NameInMap("ActionTableIndexEnd")]
            [Validation(Required=false)]
            public long? ActionTableIndexEnd { get; set; }

            [NameInMap("DbConnectMin")]
            [Validation(Required=false)]
            public long? DbConnectMin { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public long? DbType { get; set; }

            [NameInMap("DbConnMax")]
            [Validation(Required=false)]
            public long? DbConnMax { get; set; }

            [NameInMap("DsIndexStart")]
            [Validation(Required=false)]
            public long? DsIndexStart { get; set; }

            [NameInMap("DsNameFormat")]
            [Validation(Required=false)]
            public string DsNameFormat { get; set; }

            [NameInMap("ActionTableIndexStart")]
            [Validation(Required=false)]
            public long? ActionTableIndexStart { get; set; }

            [NameInMap("ActivityTableIndexEnd")]
            [Validation(Required=false)]
            public long? ActivityTableIndexEnd { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            [NameInMap("ActivityTableNameFormat")]
            [Validation(Required=false)]
            public string ActivityTableNameFormat { get; set; }

            [NameInMap("ActivityTableIndexStart")]
            [Validation(Required=false)]
            public long? ActivityTableIndexStart { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
