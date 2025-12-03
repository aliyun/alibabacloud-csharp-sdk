// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class GetAccessGroupResponseBody : TeaModel {
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public GetAccessGroupResponseBodyAccessGroup AccessGroup { get; set; }
        public class GetAccessGroupResponseBodyAccessGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acg-e3755fb0-358d-4286-9942-8d461048****</para>
            /// </summary>
            [NameInMap("AccessGroupId")]
            [Validation(Required=false)]
            public string AccessGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-cluster-policy</para>
            /// </summary>
            [NameInMap("AccessGroupName")]
            [Validation(Required=false)]
            public string AccessGroupName { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MountPointCount")]
            [Validation(Required=false)]
            public int? MountPointCount { get; set; }

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
            /// <para>3</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
