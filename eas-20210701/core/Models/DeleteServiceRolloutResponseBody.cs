// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceRolloutResponseBody : TeaModel {
        /// <summary>
        /// <para><b>Message</b>  </para>
        /// <list type="bullet">
        /// <item><description>Type: <c>string</c>  </description></item>
        /// <item><description>Description: The response message. Describes the result of the request processing.  </description></item>
        /// <item><description>Example: <c>Rollout deleted successfully</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Rollout deleted successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para><b>RequestId</b>  </para>
        /// <list type="bullet">
        /// <item><description>Type: <c>string</c>  </description></item>
        /// <item><description>Description: The request ID. A unique identifier returned for each request, used for troubleshooting and tracing.  </description></item>
        /// <item><description>Example: <c>40325405-579C-4D82-9B4F-8A7C6D5E4F3A</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
