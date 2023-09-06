// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMeetingRoomGroupResponseBody : TeaModel {
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
