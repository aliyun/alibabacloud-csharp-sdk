// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateMeetingRoomRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("IsvRoomId")]
        [Validation(Required=false)]
        public string IsvRoomId { get; set; }

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

        [NameInMap("RoomPicture")]
        [Validation(Required=false)]
        public string RoomPicture { get; set; }

        [NameInMap("RoomStatus")]
        [Validation(Required=false)]
        public int? RoomStatus { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateMeetingRoomRequestTenantContext TenantContext { get; set; }
        public class CreateMeetingRoomRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}