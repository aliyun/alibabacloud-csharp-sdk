// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceTagResponseBody : TeaModel {
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
        public GetDeviceTagResponseBodyResult Result { get; set; }
        public class GetDeviceTagResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Tag information of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{       &quot;antest1&quot;: &quot;antest1&quot;,       &quot;antest&quot;: &quot;a&quot;     }</para>
            /// </summary>
            [NameInMap("DeviceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> DeviceTags { get; set; }

        }

    }

}
