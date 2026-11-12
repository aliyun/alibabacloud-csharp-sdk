// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRolloutResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned message. Describes the request processing result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>&quot;Rollout updated successfully&quot;: The rollout policy is updated.</description></item>
        /// <item><description>&quot;Rollout paused successfully&quot;: The rollout is paused.</description></item>
        /// <item><description>&quot;Rollout resumed successfully&quot;: The rollout is resumed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Rollout updated successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. The unique identifier returned for each request, used for troubleshooting and tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
