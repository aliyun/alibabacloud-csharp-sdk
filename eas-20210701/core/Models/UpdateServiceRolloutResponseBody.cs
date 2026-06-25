// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRolloutResponseBody : TeaModel {
        /// <summary>
        /// <para>A message that indicates the result of the request. Possible values include:</para>
        /// <list type="bullet">
        /// <item><description><para>&quot;Rollout updated successfully&quot;</para>
        /// </description></item>
        /// <item><description><para>&quot;Rollout paused successfully&quot;</para>
        /// </description></item>
        /// <item><description><para>&quot;Rollout resumed successfully&quot;</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Rollout updated successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A unique identifier for the request. You can use this request ID for troubleshooting and tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
