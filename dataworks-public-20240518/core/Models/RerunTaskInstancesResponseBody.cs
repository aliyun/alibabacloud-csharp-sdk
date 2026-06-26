// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RerunTaskInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information of the batch operation. The structure is a map in which the key is the node instance ID and the value is the result information.</para>
        /// </summary>
        [NameInMap("SuccessInfo")]
        [Validation(Required=false)]
        public Dictionary<string, SuccessInfoValue> SuccessInfo { get; set; }

    }

}
