// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class QueryImageToVideoTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx/xxx.mp4">https://xxx/xxx.mp4</a></para>
        /// </summary>
        [NameInMap("originUrl")]
        [Validation(Required=false)]
        public string OriginUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CC2967CA-0114-57E0-A0CF-7DEEEDAB953D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>868125994191405056</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
