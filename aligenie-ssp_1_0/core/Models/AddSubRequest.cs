// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AddSubRequest : TeaModel {
        [NameInMap("AddSubscriptionInfoRequest")]
        [Validation(Required=false)]
        public AddSubRequestAddSubscriptionInfoRequest AddSubscriptionInfoRequest { get; set; }
        public class AddSubRequestAddSubscriptionInfoRequest : TeaModel {
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            [NameInMap("DailyStudyCnt")]
            [Validation(Required=false)]
            public int? DailyStudyCnt { get; set; }

            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public AddSubRequestAddSubscriptionInfoRequestScheduleInfo ScheduleInfo { get; set; }
            public class AddSubRequestAddSubscriptionInfoRequestScheduleInfo : TeaModel {
                [NameInMap("DaysOfWeek")]
                [Validation(Required=false)]
                public List<int?> DaysOfWeek { get; set; }

                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

            }

        }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public AddSubRequestDeviceInfo DeviceInfo { get; set; }
        public class AddSubRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public AddSubRequestUserInfo UserInfo { get; set; }
        public class AddSubRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
