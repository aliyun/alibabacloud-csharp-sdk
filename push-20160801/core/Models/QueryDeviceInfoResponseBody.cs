// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDeviceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Device details.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public QueryDeviceInfoResponseBodyDeviceInfo DeviceInfo { get; set; }
        public class QueryDeviceInfoResponseBodyDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Account attached to the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>Alias attached to the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_alias,test_alias2</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>Device brand.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HUAWEI</para>
            /// </summary>
            [NameInMap("Brand")]
            [Validation(Required=false)]
            public string Brand { get; set; }

            /// <summary>
            /// <para>Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a64ae296f3b04a58a05b30c95****</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Device token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ecc7b4012aaa801b63******5543ccbda6b4930d09629e936e1ac4b762a7df</para>
            /// </summary>
            [NameInMap("DeviceToken")]
            [Validation(Required=false)]
            public string DeviceToken { get; set; }

            /// <summary>
            /// <para>Device type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>Last online time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-03-27T02:19:40Z</para>
            /// </summary>
            [NameInMap("LastOnlineTime")]
            [Validation(Required=false)]
            public string LastOnlineTime { get; set; }

            /// <summary>
            /// <para>Device model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VOG-AL00</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>Is online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>Phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>133********</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>Is push feature enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PushEnabled")]
            [Validation(Required=false)]
            public bool? PushEnabled { get; set; }

            /// <summary>
            /// <para>Tags attached to the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_tag,test_tag2</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EEF262B-EA7D-41DC-89B9-20F3D1E28194</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
