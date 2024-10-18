// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMeetingRoomListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryMeetingRoomListResponseBodyResult> Result { get; set; }
        public class QueryMeetingRoomListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding994axxxx</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxIsvRoomId</para>
            /// </summary>
            [NameInMap("IsvRoomId")]
            [Validation(Required=false)]
            public string IsvRoomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RoomCapacity")]
            [Validation(Required=false)]
            public int? RoomCapacity { get; set; }

            [NameInMap("RoomGroup")]
            [Validation(Required=false)]
            public QueryMeetingRoomListResponseBodyResultRoomGroup RoomGroup { get; set; }
            public class QueryMeetingRoomListResponseBodyResultRoomGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试分组</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0ffb7xxxxx</para>
            /// </summary>
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("RoomLabels")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomListResponseBodyResultRoomLabels> RoomLabels { get; set; }
            public class QueryMeetingRoomListResponseBodyResultRoomLabels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LabelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>电视</para>
                /// </summary>
                [NameInMap("LabelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

            }

            [NameInMap("RoomLocation")]
            [Validation(Required=false)]
            public QueryMeetingRoomListResponseBodyResultRoomLocation RoomLocation { get; set; }
            public class QueryMeetingRoomListResponseBodyResultRoomLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx市xx区xx街道xx号</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx公司</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试会议室</para>
            /// </summary>
            [NameInMap("RoomName")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/lADPxxxxx.jpg">https://static.dingtalk.com/media/lADPxxxxx.jpg</a></para>
            /// </summary>
            [NameInMap("RoomPicture")]
            [Validation(Required=false)]
            public string RoomPicture { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012241xxxxx</para>
            /// </summary>
            [NameInMap("RoomStaffId")]
            [Validation(Required=false)]
            public string RoomStaffId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RoomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

        }

    }

}
