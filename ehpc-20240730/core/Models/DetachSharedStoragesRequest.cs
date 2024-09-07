// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class DetachSharedStoragesRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](https://help.aliyun.com/document_detail/87116.html) operation to query the cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The information about mounted shared storage resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<DetachSharedStoragesRequestSharedStorages> SharedStorages { get; set; }
        public class DetachSharedStoragesRequestSharedStorages : TeaModel {
            /// <summary>
            /// The local mount directory of the mounted file system.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MountDirectory")]
            [Validation(Required=false)]
            public string MountDirectory { get; set; }

        }

    }

}
