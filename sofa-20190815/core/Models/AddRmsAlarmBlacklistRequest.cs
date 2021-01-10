// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddRmsAlarmBlacklistRequest : TeaModel {
        [NameInMap("EnvJsonStr")]
        [Validation(Required=false)]
        public string EnvJsonStr { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AddRmsAlarmBlacklistRequestData> Data { get; set; }
        public class AddRmsAlarmBlacklistRequestData : TeaModel {
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("ApplyTargetId")]
            [Validation(Required=false)]
            public string ApplyTargetId { get; set; }

            [NameInMap("ResId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UtcCreated")]
            [Validation(Required=false)]
            public string UtcCreated { get; set; }

            [NameInMap("ResName")]
            [Validation(Required=false)]
            public string ResName { get; set; }

            [NameInMap("ValidStartTime")]
            [Validation(Required=false)]
            public string ValidStartTime { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("ResType")]
            [Validation(Required=false)]
            public string ResType { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ValidEndTime")]
            [Validation(Required=false)]
            public string ValidEndTime { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
