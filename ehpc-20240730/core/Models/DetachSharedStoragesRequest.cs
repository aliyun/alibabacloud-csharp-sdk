// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class DetachSharedStoragesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The information about mounted shared storage resources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<DetachSharedStoragesRequestSharedStorages> SharedStorages { get; set; }
        public class DetachSharedStoragesRequestSharedStorages : TeaModel {
            /// <summary>
            /// <para>The local mount directory of the mounted file system.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("MountDirectory")]
            [Validation(Required=false)]
            public string MountDirectory { get; set; }

        }

    }

}
