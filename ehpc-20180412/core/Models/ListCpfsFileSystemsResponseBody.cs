// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCpfsFileSystemsResponseBody : TeaModel {
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public ListCpfsFileSystemsResponseBodyFileSystemList FileSystemList { get; set; }
        public class ListCpfsFileSystemsResponseBodyFileSystemList : TeaModel {
            [NameInMap("FileSystems")]
            [Validation(Required=false)]
            public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystems> FileSystems { get; set; }
            public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystems : TeaModel {
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Destription")]
                [Validation(Required=false)]
                public string Destription { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("MountTargetList")]
                [Validation(Required=false)]
                public ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList MountTargetList { get; set; }
                public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList : TeaModel {
                    [NameInMap("MountTargets")]
                    [Validation(Required=false)]
                    public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets> MountTargets { get; set; }
                    public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets : TeaModel {
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

                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

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
