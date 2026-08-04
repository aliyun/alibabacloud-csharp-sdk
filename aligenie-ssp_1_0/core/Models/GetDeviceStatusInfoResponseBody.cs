// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceStatusInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned. A value of 200 indicates that the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return result of invoking this API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Detailed information returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetDeviceStatusInfoResponseBodyResult Result { get; set; }
        public class GetDeviceStatusInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the device is online. A value of 0 means offline, and 1 means online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public int? Online { get; set; }

        }

    }

}
