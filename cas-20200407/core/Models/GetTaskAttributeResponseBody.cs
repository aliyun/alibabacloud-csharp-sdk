// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetTaskAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the request. Alibaba Cloud generates this ID for each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("TaskMessage")]
        [Validation(Required=false)]
        public string TaskMessage { get; set; }

        /// <summary>
        /// <para>The result of the task.</para>
        /// <list type="bullet">
        /// <item><description><para>success: The submission is successful.</para>
        /// </description></item>
        /// <item><description><para>processing: The submission is in progress.</para>
        /// </description></item>
        /// <item><description><para>failed: The submission failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
