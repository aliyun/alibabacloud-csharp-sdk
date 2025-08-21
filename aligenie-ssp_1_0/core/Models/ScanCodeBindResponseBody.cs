// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScanCodeBindResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>686DF82F-45C4-7DF7-8B67-27B91CFD63A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ScanCodeBindResponseBodyResult Result { get; set; }
        public class ScanCodeBindResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>X1</para>
            /// </summary>
            [NameInMap("BizGroup")]
            [Validation(Required=false)]
            public string BizGroup { get; set; }

            /// <summary>
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
            /// <para>用户opneId</para>
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

        }

    }

}
