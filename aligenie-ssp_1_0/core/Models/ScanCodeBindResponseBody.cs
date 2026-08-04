// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScanCodeBindResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned error code. A value of 200 indicates that the invocation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Result message</para>
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
        /// <para>686DF82F-45C4-7DF7-8B67-27B91CFD63A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Detailed information returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ScanCodeBindResponseBodyResult Result { get; set; }
        public class ScanCodeBindResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Product group</para>
            /// 
            /// <b>Example:</b>
            /// <para>X1</para>
            /// </summary>
            [NameInMap("BizGroup")]
            [Validation(Required=false)]
            public string BizGroup { get; set; }

            /// <summary>
            /// <para>Product categorization</para>
            /// 
            /// <b>Example:</b>
            /// <para>AILABS</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>A963*0158</para>
            /// 
            /// <b>Example:</b>
            /// <para>设备OpenId</para>
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            /// <summary>
            /// <para>DAFE****ce3ej=</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户OpenId</para>
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

        }

    }

}
