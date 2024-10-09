// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInstanceVncUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The VNC connection address of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wss%3A%2F%2Fhz01-vncproxy.aliyun.com%2Fwebsockify%2F%3Fs%3Dwz3L8wEMO6KMt7%252FXInEMtKVubBB%252F7rv055kOm8eUOD%252*****YlmsKjOfz6</para>
        /// </summary>
        [NameInMap("VncUrl")]
        [Validation(Required=false)]
        public string VncUrl { get; set; }

    }

}
