// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceVncUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The VNC logon URL.</para>
        /// <remarks>
        /// <para>Notice: <b>The VNC logon URL is time-sensitive and valid for 15 seconds. If you do not use the URL within 15 seconds after a successful call, the URL expires and you must call this operation again to obtain a new one.</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>wss%3A%2F%2Fhz01-vncproxy.aliyun.com%2Fwebsockify%2F%3Fs%3DDvh%252FIA%252BYc73gWO48cBx2gBxUDVzaAnSKr74pq30mzqUYgeUMcB%252FbkNixDxdEA996</para>
        /// </summary>
        [NameInMap("VncUrl")]
        [Validation(Required=false)]
        public string VncUrl { get; set; }

    }

}
