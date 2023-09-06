// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMeetingRoomResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMeetingRoomResponseBodyResult Result { get; set; }
        public class QueryMeetingRoomResponseBodyResult : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("IsvRoomId")]
            [Validation(Required=false)]
            public string IsvRoomId { get; set; }

            [NameInMap("RoomCapacity")]
            [Validation(Required=false)]
            public int? RoomCapacity { get; set; }

            [NameInMap("RoomGroup")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultRoomGroup RoomGroup { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomGroup : TeaModel {
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("RoomLabels")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomResponseBodyResultRoomLabels> RoomLabels { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomLabels : TeaModel {
                [NameInMap("LabelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("LabelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

            }

            [NameInMap("RoomLocation")]
            [Validation(Required=false)]
            public QueryMeetingRoomResponseBodyResultRoomLocation RoomLocation { get; set; }
            public class QueryMeetingRoomResponseBodyResultRoomLocation : TeaModel {
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("RoomName")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            [NameInMap("RoomPicture")]
            [Validation(Required=false)]
            public string RoomPicture { get; set; }

            [NameInMap("RoomStaffId")]
            [Validation(Required=false)]
            public string RoomStaffId { get; set; }

            [NameInMap("RoomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

        }

    }

}
