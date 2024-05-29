// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersForGroupResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned. The maximum number of entries that can be returned per page is specified by PageSize.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The information about accounts.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersForGroupResponseBodyUsers> Users { get; set; }
        public class ListUsersForGroupResponseBodyUsers : TeaModel {
            [NameInMap("GroupMemberRelationSourceId")]
            [Validation(Required=false)]
            public string GroupMemberRelationSourceId { get; set; }

            [NameInMap("GroupMemberRelationSourceType")]
            [Validation(Required=false)]
            public string GroupMemberRelationSourceType { get; set; }

            /// <summary>
            /// The account ID.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
