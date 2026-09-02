// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class EcomVideoRecreationResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. <c>success</c> indicates success. An error code is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The asynchronous task submit status.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EcomVideoRecreationResponseBodyData Data { get; set; }
        public class EcomVideoRecreationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID for QueryAsyncTaskResult queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_778fa8bd21804828a5d147050e30edac</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The response message. An error description is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task submitted</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, used to identify a unique call.</para>
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
