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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19999</para>
            /// </summary>
            [NameInMap("WatchLiveTime")]
            [Validation(Required=false)]
            public long? WatchLiveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>131312312</para>
            /// </summary>
            [NameInMap("WatchPlaybackTime")]
            [Validation(Required=false)]
            public long? WatchPlaybackTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1323132</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>12312312</para>
            /// </summary>
            [NameInMap("WatchLiveTime")]
            [Validation(Required=false)]
            public long? WatchLiveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21313131</para>
            /// </summary>
            [NameInMap("WatchPlaybackTime")]
            [Validation(Required=false)]
            public long? WatchPlaybackTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123131</para>
            /// </summary>
            [NameInMap("WatchProgressMs")]
            [Validation(Required=false)]
            public long? WatchProgressMs { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
