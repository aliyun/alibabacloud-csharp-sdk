// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class StopTaskInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the batch operation, which is in the MAP structure. The instance ID serves as a key, and the result serves as a value.</para>
        /// </summary>
        [NameInMap("SuccessInfo")]
        [Validation(Required=false)]
        public Dictionary<string, SuccessInfoValue> SuccessInfo { get; set; }

    }

}
