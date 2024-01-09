// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class FailbackRequest : TeaModel {
        [NameInMap("RecoveryCpu")]
        [Validation(Required=false)]
        public int? RecoveryCpu { get; set; }

        [NameInMap("RecoveryInfrastructureId")]
        [Validation(Required=false)]
        public string RecoveryInfrastructureId { get; set; }

        [NameInMap("RecoveryInstanceName")]
        [Validation(Required=false)]
        public string RecoveryInstanceName { get; set; }

        [NameInMap("RecoveryInstanceType")]
        [Validation(Required=false)]
        public string RecoveryInstanceType { get; set; }

        [NameInMap("RecoveryIpAddress")]
        [Validation(Required=false)]
        public string RecoveryIpAddress { get; set; }

        [NameInMap("RecoveryMemory")]
        [Validation(Required=false)]
        public long? RecoveryMemory { get; set; }

        [NameInMap("RecoveryNetwork")]
        [Validation(Required=false)]
        public string RecoveryNetwork { get; set; }

        [NameInMap("RecoveryPointId")]
        [Validation(Required=false)]
        public string RecoveryPointId { get; set; }

        [NameInMap("RecoveryPostScriptContent")]
        [Validation(Required=false)]
        public string RecoveryPostScriptContent { get; set; }

        [NameInMap("RecoveryPostScriptType")]
        [Validation(Required=false)]
        public string RecoveryPostScriptType { get; set; }

        [NameInMap("RecoveryReserveIp")]
        [Validation(Required=false)]
        public bool? RecoveryReserveIp { get; set; }

        [NameInMap("RecoveryUseDhcp")]
        [Validation(Required=false)]
        public bool? RecoveryUseDhcp { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

    }

}
