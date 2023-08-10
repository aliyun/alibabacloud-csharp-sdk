// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// The queried account groups.
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<ListGroupsForUserResponseBodyGroups> Groups { get; set; }
        public class ListGroupsForUserResponseBodyGroups : TeaModel {
            /// <summary>
            /// The group ID.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned. The maximum number of entries returned at a time depends on the value of PageSize.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
