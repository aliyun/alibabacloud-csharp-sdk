// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAttachScriptsRequest : TeaModel {
        /// <summary>
        /// 节点CPU架构,支持amd64、arm、arm64。
        /// </summary>
        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// 边缘托管版集群节点的接入配置。
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public DescribeClusterAttachScriptsRequestOptions Options { get; set; }
        public class DescribeClusterAttachScriptsRequestOptions : TeaModel {
            [NameInMap("allowedClusterAddons")]
            [Validation(Required=false)]
            public List<string> AllowedClusterAddons { get; set; }
            [NameInMap("enableIptables")]
            [Validation(Required=false)]
            public bool? EnableIptables { get; set; }
            [NameInMap("flannelIface")]
            [Validation(Required=false)]
            public string FlannelIface { get; set; }
            [NameInMap("gpuVersion")]
            [Validation(Required=false)]
            public string GpuVersion { get; set; }
            [NameInMap("manageRuntime")]
            [Validation(Required=false)]
            public bool? ManageRuntime { get; set; }
            [NameInMap("nodeNameOverride")]
            [Validation(Required=false)]
            public string NodeNameOverride { get; set; }
            [NameInMap("quiet")]
            [Validation(Required=false)]
            public string Quiet { get; set; }
        };

    }

}
