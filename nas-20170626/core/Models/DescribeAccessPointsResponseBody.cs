// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessPointsResponseBody : TeaModel {
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<DescribeAccessPointsResponseBodyAccessPoints> AccessPoints { get; set; }
        public class DescribeAccessPointsResponseBodyAccessPoints : TeaModel {
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
            public DescribeAccessPointsResponseBodyAccessPointsPosixUser PosixUser { get; set; }
            public class DescribeAccessPointsResponseBodyAccessPointsPosixUser : TeaModel {
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

            [NameInMap("RootPath")]
            [Validation(Required=false)]
            public string RootPath { get; set; }

            [NameInMap("RootPathPermission")]
            [Validation(Required=false)]
            public DescribeAccessPointsResponseBodyAccessPointsRootPathPermission RootPathPermission { get; set; }
            public class DescribeAccessPointsResponseBodyAccessPointsRootPathPermission : TeaModel {
                [NameInMap("OwnerGroupId")]
                [Validation(Required=false)]
                public long? OwnerGroupId { get; set; }

                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public long? OwnerUserId { get; set; }

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

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
