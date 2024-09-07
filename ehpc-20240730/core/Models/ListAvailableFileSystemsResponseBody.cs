// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListAvailableFileSystemsResponseBody : TeaModel {
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public List<ListAvailableFileSystemsResponseBodyFileSystemList> FileSystemList { get; set; }
        public class ListAvailableFileSystemsResponseBodyFileSystemList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            [NameInMap("MountTargetList")]
            [Validation(Required=false)]
            public List<ListAvailableFileSystemsResponseBodyFileSystemListMountTargetList> MountTargetList { get; set; }
            public class ListAvailableFileSystemsResponseBodyFileSystemListMountTargetList : TeaModel {
                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
