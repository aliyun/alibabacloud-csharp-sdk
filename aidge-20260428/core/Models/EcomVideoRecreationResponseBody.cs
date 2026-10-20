// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class EcomVideoRecreationResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The result code. A value of <c>success</c> indicates success. If the call fails, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The submission result of the asynchronous task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EcomVideoRecreationResponseBodyData Data { get; set; }
        public class EcomVideoRecreationResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The ID of the asynchronous task, which is used to query the task result by calling QueryAsyncTaskResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_778fa8bd21804828a5d147050e30edac</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The return message. If the call fails, an error description is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task submitted</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to identify a unique call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the submission is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

