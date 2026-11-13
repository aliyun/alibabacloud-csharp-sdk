// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class StopTaskInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. You can use this ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information of the batch operation. The structure is a map with the task instance ID as the key and the result information as the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;10001&quot;: {&quot;Success&quot;: false, &quot;Message&quot;: &quot;The instance does not exist.&quot;}}</para>
        /// </summary>
        [NameInMap("SuccessInfo")]
        [Validation(Required=false)]
        public Dictionary<string, SuccessInfoValue> SuccessInfo { get; set; }

    }

}
