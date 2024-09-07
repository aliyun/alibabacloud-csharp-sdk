// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UpdateClusterRequest : TeaModel {
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public UpdateClusterRequestClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class UpdateClusterRequestClusterCustomConfiguration : TeaModel {
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        [NameInMap("EnableScaleOut")]
        [Validation(Required=false)]
        public bool? EnableScaleOut { get; set; }

        [NameInMap("GrowInterval")]
        [Validation(Required=false)]
        public int? GrowInterval { get; set; }

        [NameInMap("IdleInterval")]
        [Validation(Required=false)]
        public int? IdleInterval { get; set; }

        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public int? MaxCoreCount { get; set; }

        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

    }

}
