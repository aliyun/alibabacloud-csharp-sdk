/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class CreateSandboxInstanceRequest : TeaModel {
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        [NameInMap("SandboxInstanceName")]
        [Validation(Required=false)]
        public string SandboxInstanceName { get; set; }

        [NameInMap("SandboxPassword")]
        [Validation(Required=false)]
        public string SandboxPassword { get; set; }

        [NameInMap("SandboxSpecification")]
        [Validation(Required=false)]
        public string SandboxSpecification { get; set; }

        [NameInMap("SandboxType")]
        [Validation(Required=false)]
        public string SandboxType { get; set; }

        [NameInMap("SandboxUser")]
        [Validation(Required=false)]
        public string SandboxUser { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VpcSwitchId")]
        [Validation(Required=false)]
        public string VpcSwitchId { get; set; }

    }

}
