// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class QueryRecognitionResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ORDER_001</para>
        /// </summary>
        [NameInMap("OrderUniqueId")]
        [Validation(Required=false)]
        public string OrderUniqueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TASK_001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
