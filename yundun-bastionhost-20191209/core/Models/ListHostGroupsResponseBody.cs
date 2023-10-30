// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostGroupsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the host groups.
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<ListHostGroupsResponseBodyHostGroups> HostGroups { get; set; }
        public class ListHostGroupsResponseBodyHostGroups : TeaModel {
            /// <summary>
            /// The description of the host group.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The ID of the host group.
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            /// <summary>
            /// The name of the host group.
            /// </summary>
            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

            /// <summary>
            /// The number of hosts in the host group.
            /// </summary>
            [NameInMap("MemberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of host groups returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
