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
            /// <summary>
            /// <b>Example:</b>
            /// <para>51999575</para>
            /// </summary>
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DailyStudyCnt")]
            [Validation(Required=false)]
            public int? DailyStudyCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sequence</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

            }

        }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public AddSubRequestDeviceInfo DeviceInfo { get; set; }
        public class AddSubRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
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
