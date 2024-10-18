// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateMeetingRoomRequest : TeaModel {
        [NameInMap("EnableCycleReservation")]
        [Validation(Required=false)]
        public bool? EnableCycleReservation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4644</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxIsvRoomId</para>
        /// </summary>
        [NameInMap("IsvRoomId")]
        [Validation(Required=false)]
        public string IsvRoomId { get; set; }

        [NameInMap("ReservationAuthority")]
        [Validation(Required=false)]
        public CreateMeetingRoomRequestReservationAuthority ReservationAuthority { get; set; }
        public class CreateMeetingRoomRequestReservationAuthority : TeaModel {
            [NameInMap("AuthorizedMembers")]
            [Validation(Required=false)]
            public List<CreateMeetingRoomRequestReservationAuthorityAuthorizedMembers> AuthorizedMembers { get; set; }
            public class CreateMeetingRoomRequestReservationAuthorityAuthorizedMembers : TeaModel {
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("MemberType")]
                [Validation(Required=false)]
                public string MemberType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RoomCapacity")]
        [Validation(Required=false)]
        public int? RoomCapacity { get; set; }

        [NameInMap("RoomLabelIds")]
        [Validation(Required=false)]
        public List<long?> RoomLabelIds { get; set; }

        [NameInMap("RoomLocation")]
        [Validation(Required=false)]
        public CreateMeetingRoomRequestRoomLocation RoomLocation { get; set; }
        public class CreateMeetingRoomRequestRoomLocation : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://static.dingtalk.com/media/lADPxxxxx.jpg">https://static.dingtalk.com/media/lADPxxxxx.jpg</a></para>
        /// </summary>
        [NameInMap("RoomPicture")]
        [Validation(Required=false)]
        public string RoomPicture { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoomStatus")]
        [Validation(Required=false)]
        public int? RoomStatus { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateMeetingRoomRequestTenantContext TenantContext { get; set; }
        public class CreateMeetingRoomRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
