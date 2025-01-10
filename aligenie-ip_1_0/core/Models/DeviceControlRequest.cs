// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class DeviceControlRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public DeviceControlRequestPayload Payload { get; set; }
        public class DeviceControlRequestPayload : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aircondition</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("Cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>air_condition</para>
            /// </summary>
            [NameInMap("DeviceNumber")]
            [Validation(Required=false)]
            public string DeviceNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>room</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, string> Properties { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DeviceControlRequestUserInfo UserInfo { get; set; }
        public class DeviceControlRequestUserInfo : TeaModel {
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
            /// <para>HOFF****my7Iw=</para>
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
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
