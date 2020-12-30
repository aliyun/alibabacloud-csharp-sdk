// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountTargetsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("MountTargets")]
        [Validation(Required=false)]
        public DescribeMountTargetsResponseBodyMountTargets MountTargets { get; set; }
        public class DescribeMountTargetsResponseBodyMountTargets : TeaModel {
            [NameInMap("MountTarget")]
            [Validation(Required=false)]
            public List<DescribeMountTargetsResponseBodyMountTargetsMountTarget> MountTarget { get; set; }
            public class DescribeMountTargetsResponseBodyMountTargetsMountTarget : TeaModel {
                public string VpcId { get; set; }
                public string Status { get; set; }
                public DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes ClientMasterNodes { get; set; }
                public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes : TeaModel {
                    [NameInMap("ClientMasterNode")]
                    [Validation(Required=false)]
                    public List<DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode> ClientMasterNode { get; set; }
                    public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode : TeaModel {
                        [NameInMap("EcsId")]
                        [Validation(Required=false)]
                        public string EcsId { get; set; }

                        [NameInMap("DefaultPasswd")]
                        [Validation(Required=false)]
                        public string DefaultPasswd { get; set; }

                        [NameInMap("EcsIp")]
                        [Validation(Required=false)]
                        public string EcsIp { get; set; }

                    }

                }
                public string MountTargetDomain { get; set; }
                public string AccessGroup { get; set; }
                public string DualStackMountTargetDomain { get; set; }
                public string VswId { get; set; }
                public string NetworkType { get; set; }
            }
        };

    }

}
