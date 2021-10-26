// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListFileSystemWithMountTargetsResponseBody : TeaModel {
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public ListFileSystemWithMountTargetsResponseBodyFileSystemList FileSystemList { get; set; }
        public class ListFileSystemWithMountTargetsResponseBodyFileSystemList : TeaModel {
            [NameInMap("FileSystems")]
            [Validation(Required=false)]
            public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystems> FileSystems { get; set; }
            public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystems : TeaModel {
                public int? BandWidth { get; set; }
                public int? Capacity { get; set; }
                public string CreateTime { get; set; }
                public string Destription { get; set; }
                public int? EncryptType { get; set; }
                public string FileSystemId { get; set; }
                public string FileSystemType { get; set; }
                public int? MeteredSize { get; set; }
                public ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetList MountTargetList { get; set; }
                public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetList : TeaModel {
                    [NameInMap("MountTargets")]
                    [Validation(Required=false)]
                    public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets> MountTargets { get; set; }
                    public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets : TeaModel {
                        [NameInMap("AccessGroup")]
                        [Validation(Required=false)]
                        public string AccessGroup { get; set; }

                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                    }

                }
                public ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageList PackageList { get; set; }
                public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageList : TeaModel {
                    [NameInMap("Packages")]
                    [Validation(Required=false)]
                    public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageListPackages> Packages { get; set; }
                    public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageListPackages : TeaModel {
                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                    }

                }
                public string ProtocolType { get; set; }
                public string RegionId { get; set; }
                public string Status { get; set; }
                public string StorageType { get; set; }
            }
        };

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
