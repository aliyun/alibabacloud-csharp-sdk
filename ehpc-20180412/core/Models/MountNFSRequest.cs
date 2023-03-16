// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class MountNFSRequest : TeaModel {
        /// <summary>
        /// The ID of the visualization instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The local mount directory.
        /// </summary>
        [NameInMap("MountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// The address of the mount target.
        /// </summary>
        [NameInMap("NfsDir")]
        [Validation(Required=false)]
        public string NfsDir { get; set; }

        /// <summary>
        /// The type of the protocol. Valid values:
        /// 
        /// *   nfs
        /// *   smb
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The remote mount address.
        /// </summary>
        [NameInMap("RemoteDir")]
        [Validation(Required=false)]
        public string RemoteDir { get; set; }

    }

}
