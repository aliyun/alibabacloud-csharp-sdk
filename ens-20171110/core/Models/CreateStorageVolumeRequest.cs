// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageVolumeRequest : TeaModel {
        /// <summary>
        /// The password of the CHAP protocol.
        /// </summary>
        [NameInMap("AuthPassword")]
        [Validation(Required=false)]
        public string AuthPassword { get; set; }

        /// <summary>
        /// The authentication protocol. Set the value to **CHAP**.
        /// </summary>
        [NameInMap("AuthProtocol")]
        [Validation(Required=false)]
        public string AuthProtocol { get; set; }

        /// <summary>
        /// The username of the CHAP protocol.
        /// </summary>
        [NameInMap("AuthUser")]
        [Validation(Required=false)]
        public string AuthUser { get; set; }

        /// <summary>
        /// The description of the volume. The description must be 2 to 128 characters in length. The description cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Specifies whether to enable authentication. Valid values:
        /// 
        /// *   **1**: enable authentication.
        /// *   **0** (default): disable authentication.
        /// </summary>
        [NameInMap("IsAuth")]
        [Validation(Required=false)]
        public string IsAuth { get; set; }

        /// <summary>
        /// Specifies whether to enable the volume. Valid values:
        /// 
        /// *   **1** (default): enable the volume.
        /// *   **0**: disable the volume.
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public string IsEnable { get; set; }

        /// <summary>
        /// The ID of the storage medium.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorageId")]
        [Validation(Required=false)]
        public string StorageId { get; set; }

        /// <summary>
        /// The name of the volume. The name must be 2 to 128 characters in length. The name cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("VolumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
