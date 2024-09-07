// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSharedStoragesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the attached shared storage.
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<ListSharedStoragesResponseBodySharedStorages> SharedStorages { get; set; }
        public class ListSharedStoragesResponseBodySharedStorages : TeaModel {
            /// <summary>
            /// The ID of the attached file system.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// The protocol used by the attached file system. Valid values:
            /// 
            /// *   nfs3
            /// *   nfs4
            /// *   cpfs
            /// </summary>
            [NameInMap("FileSystemProtocol")]
            [Validation(Required=false)]
            public string FileSystemProtocol { get; set; }

            /// <summary>
            /// The type of the attached file system. Valid values:
            /// 
            /// *   nas
            /// *   cpfs
            /// </summary>
            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            /// <summary>
            /// The mount information.
            /// </summary>
            [NameInMap("MountInfo")]
            [Validation(Required=false)]
            public List<ListSharedStoragesResponseBodySharedStoragesMountInfo> MountInfo { get; set; }
            public class ListSharedStoragesResponseBodySharedStoragesMountInfo : TeaModel {
                /// <summary>
                /// The local mount directory of the attached file system.
                /// </summary>
                [NameInMap("MountDirectory")]
                [Validation(Required=false)]
                public string MountDirectory { get; set; }

                /// <summary>
                /// The mount options for the attached file system. Valid values:
                /// 
                /// *   \\-t nfs -o vers=3,nolock,proto=tcp,noresvport
                /// *   \\-t nfs -o vers=4.0,noresvport
                /// </summary>
                [NameInMap("MountOptions")]
                [Validation(Required=false)]
                public string MountOptions { get; set; }

                /// <summary>
                /// The mount target of the attached file system.
                /// </summary>
                [NameInMap("MountTarget")]
                [Validation(Required=false)]
                public string MountTarget { get; set; }

                /// <summary>
                /// The protocol used by the mount target of the attached file system. Valid values:
                /// 
                /// *   nfs3
                /// *   nfs4
                /// *   cpfs
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// The storage directory of the attached file system.
                /// </summary>
                [NameInMap("StorageDirectory")]
                [Validation(Required=false)]
                public string StorageDirectory { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
