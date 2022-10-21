// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClusterSummary : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterState")]
        [Validation(Required=false)]
        public string ClusterState { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("EmrDefaultRole")]
        [Validation(Required=false)]
        public string EmrDefaultRole { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("ReadyTime")]
        [Validation(Required=false)]
        public long? ReadyTime { get; set; }

        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public ClusterStateChangeReason StateChangeReason { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
