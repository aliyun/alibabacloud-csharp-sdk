// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceVncUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The VNC logon address.</para>
        /// <remarks>
        /// <para> The address returned is valid only for 15 seconds. If you do not use the returned address to establish a connection within 15 seconds, the address expires and you must call the operation again to obtain a new address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://g.alicdn.com/aliyun/ecs-console-vnc2/0.0.8/index.html?vncUrl=****&instanceId=i-2vcb1qjj8z5dl8iw****&isWindows=false">https://g.alicdn.com/aliyun/ecs-console-vnc2/0.0.8/index.html?vncUrl=****&amp;instanceId=i-2vcb1qjj8z5dl8iw****&amp;isWindows=false</a></para>
        /// </summary>
        [NameInMap("LoginUrl")]
        [Validation(Required=false)]
        public string LoginUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2911788-25E8-42E5-A3A3-1B38D263F01E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
