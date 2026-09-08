// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Device list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDevicesResponseBodyData> Data { get; set; }
        public class ListDevicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Call ID from the registration signaling initiated by the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d7b818c3-8d3a-732f-bc9e-1782wa16****</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>Device address information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sip:8032****@33.89.XX.XX:64189;transport=tcp;registering_acc=18_134_23_4</para>
            /// </summary>
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            /// <summary>
            /// <para>Device ID, which is the identity ID of a browser Web Real-Time Communication (WebRTC) softphone or a physical phone device. Only one type of device can be registered at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACC-YUNBS-1.0.10-****</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Device type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHAT</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>Device registration expiration time, in UNIX timestamp format with millisecond precision. If the device does not re-register after expiration, it will go offline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1609118499750</para>
            /// </summary>
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public long? Expires { get; set; }

            /// <summary>
            /// <para>Agent extension number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8032****</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>List of response parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
