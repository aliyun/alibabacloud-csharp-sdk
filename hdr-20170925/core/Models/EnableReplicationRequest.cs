// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class EnableReplicationRequest : TeaModel {
        [NameInMap("CrashConsistentPointPolicy")]
        [Validation(Required=false)]
        public string CrashConsistentPointPolicy { get; set; }

        [NameInMap("RecoveryNetwork")]
        [Validation(Required=false)]
        public string RecoveryNetwork { get; set; }

        [NameInMap("ReplicationNetwork")]
        [Validation(Required=false)]
        public string ReplicationNetwork { get; set; }

        [NameInMap("ReplicationUseEssd")]
        [Validation(Required=false)]
        public bool? ReplicationUseEssd { get; set; }

        [NameInMap("ReplicationUseSsd")]
        [Validation(Required=false)]
        public bool? ReplicationUseSsd { get; set; }

        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

    }

}
