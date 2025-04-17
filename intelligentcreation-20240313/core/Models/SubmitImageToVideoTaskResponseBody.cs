// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SubmitImageToVideoTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>job added successfully</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>53AED51A-74CE-57CE-B1BF-2703F314EEC8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
