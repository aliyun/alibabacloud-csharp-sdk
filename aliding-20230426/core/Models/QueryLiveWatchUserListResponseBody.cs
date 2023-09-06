// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryLiveWatchUserListResponseBody : TeaModel {
        [NameInMap("orgUsesList")]
        [Validation(Required=false)]
        public List<QueryLiveWatchUserListResponseBodyOrgUsesList> OrgUsesList { get; set; }
        public class QueryLiveWatchUserListResponseBodyOrgUsesList : TeaModel {
            [NameInMap("DeptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("WatchLiveTime")]
            [Validation(Required=false)]
            public long? WatchLiveTime { get; set; }

            [NameInMap("WatchPlaybackTime")]
            [Validation(Required=false)]
            public long? WatchPlaybackTime { get; set; }

            [NameInMap("WatchProgressMs")]
            [Validation(Required=false)]
            public long? WatchProgressMs { get; set; }

        }

        [NameInMap("outOrgUserList")]
        [Validation(Required=false)]
        public List<QueryLiveWatchUserListResponseBodyOutOrgUserList> OutOrgUserList { get; set; }
        public class QueryLiveWatchUserListResponseBodyOutOrgUserList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("WatchLiveTime")]
            [Validation(Required=false)]
            public long? WatchLiveTime { get; set; }

            [NameInMap("WatchPlaybackTime")]
            [Validation(Required=false)]
            public long? WatchPlaybackTime { get; set; }

            [NameInMap("WatchProgressMs")]
            [Validation(Required=false)]
            public long? WatchProgressMs { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
