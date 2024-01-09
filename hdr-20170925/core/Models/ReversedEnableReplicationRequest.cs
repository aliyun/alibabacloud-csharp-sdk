// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class ReversedEnableReplicationRequest : TeaModel {
        /// <summary>
        /// -
        /// </summary>
        [NameInMap("AppConsistentPointPolicy")]
        [Validation(Required=false)]
        public string AppConsistentPointPolicy { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("CrashConsistentPointPolicy")]
        [Validation(Required=false)]
        public string CrashConsistentPointPolicy { get; set; }

        [NameInMap("RecoveryNetwork")]
        [Validation(Required=false)]
        public string RecoveryNetwork { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationComputeResource")]
        [Validation(Required=false)]
        public string ReplicationComputeResource { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationDatastore")]
        [Validation(Required=false)]
        public string ReplicationDatastore { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationDns")]
        [Validation(Required=false)]
        public string ReplicationDns { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationGateway")]
        [Validation(Required=false)]
        public string ReplicationGateway { get; set; }

        [NameInMap("ReplicationInfrastructureId")]
        [Validation(Required=false)]
        public string ReplicationInfrastructureId { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationIpAddress")]
        [Validation(Required=false)]
        public string ReplicationIpAddress { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationLocation")]
        [Validation(Required=false)]
        public string ReplicationLocation { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationNetMask")]
        [Validation(Required=false)]
        public string ReplicationNetMask { get; set; }

        [NameInMap("ReplicationNetwork")]
        [Validation(Required=false)]
        public string ReplicationNetwork { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationUseDhcp")]
        [Validation(Required=false)]
        public bool? ReplicationUseDhcp { get; set; }

        [NameInMap("ReplicationUseOriginalInstance")]
        [Validation(Required=false)]
        public bool? ReplicationUseOriginalInstance { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ShadowInstanceType")]
        [Validation(Required=false)]
        public string ShadowInstanceType { get; set; }

    }

}
