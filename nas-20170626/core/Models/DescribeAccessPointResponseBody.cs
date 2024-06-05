// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessPointResponseBody : TeaModel {
        [NameInMap("AccessPoint")]
        [Validation(Required=false)]
        public DescribeAccessPointResponseBodyAccessPoint AccessPoint { get; set; }
        public class DescribeAccessPointResponseBodyAccessPoint : TeaModel {
            [NameInMap("ARN")]
            [Validation(Required=false)]
            public string ARN { get; set; }

            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public string AccessGroup { get; set; }

            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("EnabledRam")]
            [Validation(Required=false)]
            public bool? EnabledRam { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("PosixUser")]
            [Validation(Required=false)]
            public DescribeAccessPointResponseBodyAccessPointPosixUser PosixUser { get; set; }
            public class DescribeAccessPointResponseBodyAccessPointPosixUser : TeaModel {
                [NameInMap("PosixGroupId")]
                [Validation(Required=false)]
                public int? PosixGroupId { get; set; }

                [NameInMap("PosixSecondaryGroupIds")]
                [Validation(Required=false)]
                public List<int?> PosixSecondaryGroupIds { get; set; }

                [NameInMap("PosixUserId")]
                [Validation(Required=false)]
                public int? PosixUserId { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RootPath")]
            [Validation(Required=false)]
            public string RootPath { get; set; }

            [NameInMap("RootPathPermission")]
            [Validation(Required=false)]
            public DescribeAccessPointResponseBodyAccessPointRootPathPermission RootPathPermission { get; set; }
            public class DescribeAccessPointResponseBodyAccessPointRootPathPermission : TeaModel {
                [NameInMap("OwnerGroupId")]
                [Validation(Required=false)]
                public int? OwnerGroupId { get; set; }

                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public int? OwnerUserId { get; set; }

                [NameInMap("Permission")]
                [Validation(Required=false)]
                public string Permission { get; set; }

            }

            [NameInMap("RootPathStatus")]
            [Validation(Required=false)]
            public string RootPathStatus { get; set; }

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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
