// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateMeetingRoomShrinkRequest : TeaModel {
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
        public string ReservationAuthorityShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RoomCapacity")]
        [Validation(Required=false)]
        public int? RoomCapacity { get; set; }

        [NameInMap("RoomLabelIds")]
        [Validation(Required=false)]
        public string RoomLabelIdsShrink { get; set; }

        [NameInMap("RoomLocation")]
        [Validation(Required=false)]
        public string RoomLocationShrink { get; set; }

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
        public string TenantContextShrink { get; set; }

    }

}
