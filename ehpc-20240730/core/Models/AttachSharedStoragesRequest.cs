// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class AttachSharedStoragesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<AttachSharedStoragesRequestSharedStorages> SharedStorages { get; set; }
        public class AttachSharedStoragesRequestSharedStorages : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MountDirectory")]
            [Validation(Required=false)]
            public string MountDirectory { get; set; }

            [NameInMap("MountOptions")]
            [Validation(Required=false)]
            public string MountOptions { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MountTarget")]
            [Validation(Required=false)]
            public string MountTarget { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("StorageDirectory")]
            [Validation(Required=false)]
            public string StorageDirectory { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

        }

    }

}
