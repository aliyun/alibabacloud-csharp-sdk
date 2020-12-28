// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListFileSystemWithMountTargetsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public List<ListFileSystemWithMountTargetsResponseBodyFileSystemList> FileSystemList { get; set; }
        public class ListFileSystemWithMountTargetsResponseBodyFileSystemList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            [NameInMap("MountTargetList")]
            [Validation(Required=false)]
            public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListMountTargetList> MountTargetList { get; set; }
            public class ListFileSystemWithMountTargetsResponseBodyFileSystemListMountTargetList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                [NameInMap("AccessGroup")]
                [Validation(Required=false)]
                public string AccessGroup { get; set; }

                [NameInMap("VswId")]
                [Validation(Required=false)]
                public string VswId { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("PackageList")]
            [Validation(Required=false)]
            public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListPackageList> PackageList { get; set; }
            public class ListFileSystemWithMountTargetsResponseBodyFileSystemListPackageList : TeaModel {
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

            }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public int? BandWidth { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("MeteredSize")]
            [Validation(Required=false)]
            public int? MeteredSize { get; set; }

            [NameInMap("EncryptType")]
            [Validation(Required=false)]
            public int? EncryptType { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("Destription")]
            [Validation(Required=false)]
            public string Destription { get; set; }

        }

    }

}
