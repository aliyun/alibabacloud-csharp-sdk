// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class SubmitProductMatchResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The submit result of the matching product identification asynchronous task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitProductMatchResponseBodyData Data { get; set; }
        public class SubmitProductMatchResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task acceptance time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-20T09:30:00Z</para>
            /// </summary>
            [NameInMap("SubmittedAt")]
            [Validation(Required=false)]
            public string SubmittedAt { get; set; }

            /// <summary>
            /// <para>The asynchronous task ID used for QueryAsyncTaskResult queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b7ea15cb609f47b7999d2d68dfbf3c90</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
