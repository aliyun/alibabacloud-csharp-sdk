// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SendConsoleMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F1D7E42-06A8-4B50-9A21-6E0C8D3F5B72</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is accepted. A value of true indicates success, and a value of false indicates failure. For asynchronous pushes, a successful acceptance does not mean that all targets have received the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
