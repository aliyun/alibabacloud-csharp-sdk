// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// <list type="bullet">
        /// <item><description>1001: The request was successful.</description></item>
        /// <item><description>1002: The request failed.</description></item>
        /// <item><description>1003: Parameter errors occurred.</description></item>
        /// <item><description>1004: Authentication failed.</description></item>
        /// <item><description>1006: The task does not exist.</description></item>
        /// <item><description>1099: Internal errors occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the synthetic monitoring task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSyntheticTaskResponseBodyData Data { get; set; }
        public class CreateSyntheticTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the synthetic monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned when the task failed to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
