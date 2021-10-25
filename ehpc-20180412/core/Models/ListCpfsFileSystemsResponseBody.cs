// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCpfsFileSystemsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public ListCpfsFileSystemsResponseBodyFileSystemList FileSystemList { get; set; }
        public class ListCpfsFileSystemsResponseBodyFileSystemList : TeaModel {
            [NameInMap("FileSystems")]
            [Validation(Required=false)]
            public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystems> FileSystems { get; set; }
            public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystems : TeaModel {
                public string FileSystemId { get; set; }
                public string Capacity { get; set; }
                public string CreateTime { get; set; }
                public string ZoneId { get; set; }
                public string ProtocolType { get; set; }
                public string Destription { get; set; }
                public string RegionId { get; set; }
                public ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList MountTargetList { get; set; }
                public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList : TeaModel {
                    [NameInMap("MountTargets")]
                    [Validation(Required=false)]
                    public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets> MountTargets { get; set; }
                    public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets : TeaModel {
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                    }

                }
            }
        };

    }

}
