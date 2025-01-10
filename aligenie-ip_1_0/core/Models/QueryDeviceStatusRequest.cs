// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryDeviceStatusRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public QueryDeviceStatusRequestPayload Payload { get; set; }
        public class QueryDeviceStatusRequestPayload : TeaModel {
            [NameInMap("LocationDevices")]
            [Validation(Required=false)]
            public List<QueryDeviceStatusRequestPayloadLocationDevices> LocationDevices { get; set; }
            public class QueryDeviceStatusRequestPayloadLocationDevices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>night_light</para>
                /// </summary>
                [NameInMap("DeviceNumber")]
                [Validation(Required=false)]
                public string DeviceNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>light</para>
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>room</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

            }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, string> Properties { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public QueryDeviceStatusRequestUserInfo UserInfo { get; set; }
        public class QueryDeviceStatusRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOTEL</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rV/XSgPuxZjx/hN3iw8U+e8ou***lk1r43LWcVW6fvY1Rr4sEPFodpnA==</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
