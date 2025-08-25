// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class PushQueryDeviceStateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PushQueryDeviceStateResponseBodyData Data { get; set; }
        public class PushQueryDeviceStateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ad-000f18w8vmqtzhvbopge-854</para>
            /// </summary>
            [NameInMap("DeliveryToken")]
            [Validation(Required=false)]
            public string DeliveryToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ad-000f18w8vmqtzhvbopge-854</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>miui</para>
            /// </summary>
            [NameInMap("Manufacturer")]
            [Validation(Required=false)]
            public string Manufacturer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>android</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("Statue")]
            [Validation(Required=false)]
            public string Statue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IQAAAACy0f7tAABYiMwLEENtr0TKYJEsv7wyu4Ubt9XXwTJAlknnCb1LAzB3wJvoZIcT_nJdaMhEoXJaqQrObAGHLGoU1GOexlTcLWzja-0HfGHKBw</para>
            /// </summary>
            [NameInMap("ThirdToken")]
            [Validation(Required=false)]
            public string ThirdToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>push_test</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
