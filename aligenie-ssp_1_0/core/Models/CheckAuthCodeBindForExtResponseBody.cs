// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CheckAuthCodeBindForExtResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned error code. The value 200 indicates that the invocation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Return Result of invoking this API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Detailed information</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckAuthCodeBindForExtResponseBodyResult Result { get; set; }
        public class CheckAuthCodeBindForExtResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Device open information</para>
            /// </summary>
            [NameInMap("DeviceOpenInfo")]
            [Validation(Required=false)]
            public CheckAuthCodeBindForExtResponseBodyResultDeviceOpenInfo DeviceOpenInfo { get; set; }
            public class CheckAuthCodeBindForExtResponseBodyResultDeviceOpenInfo : TeaModel {
                /// <summary>
                /// <para>External device ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>A963*0158</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>DEVICE_ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEVICE_ID</para>
                /// </summary>
                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

            }

            /// <summary>
            /// <para>User open information</para>
            /// </summary>
            [NameInMap("UserOpenInfo")]
            [Validation(Required=false)]
            public CheckAuthCodeBindForExtResponseBodyResultUserOpenInfo UserOpenInfo { get; set; }
            public class CheckAuthCodeBindForExtResponseBodyResultUserOpenInfo : TeaModel {
                /// <summary>
                /// <para>External user ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>0963*0158</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>USER_ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER_ID</para>
                /// </summary>
                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

            }

        }

    }

}
