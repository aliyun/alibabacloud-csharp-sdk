// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListMountPointsResponseBody : TeaModel {
        [NameInMap("MountPoints")]
        [Validation(Required=false)]
        public List<ListMountPointsResponseBodyMountPoints> MountPoints { get; set; }
        public class ListMountPointsResponseBodyMountPoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acg-e3755fb0-358d-4286-9942-8d461048****</para>
            /// </summary>
            [NameInMap("AccessGroupId")]
            [Validation(Required=false)]
            public string AccessGroupId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("MountPointAlias")]
            [Validation(Required=false)]
            public string MountPointAlias { get; set; }

            [NameInMap("MountPointDomain")]
            [Validation(Required=false)]
            public string MountPointDomain { get; set; }

            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Inactive</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-iq8fymi327krd14mt****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-iq8hhsk3ymzv9m4wn****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
