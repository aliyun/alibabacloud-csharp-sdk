// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetProjectTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20230823218109326025-1200</para>
        /// </summary>
        [NameInMap("IdempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>313123123</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
