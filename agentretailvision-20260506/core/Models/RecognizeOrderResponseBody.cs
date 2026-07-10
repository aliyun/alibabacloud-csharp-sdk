// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class RecognizeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. This parameter is not returned during a normal call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Recognition task information</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeOrderResponseBodyData Data { get; set; }
        public class RecognizeOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Unique idempotent ID of the business party</para>
            /// 
            /// <b>Example:</b>
            /// <para>ORDER_001</para>
            /// </summary>
            [NameInMap("OrderUniqueId")]
            [Validation(Required=false)]
            public string OrderUniqueId { get; set; }

            /// <summary>
            /// <para>Platform task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>TASK_001</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Task status</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROCESSING</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>Error message. This parameter is not returned during a normal call.</para>
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
        /// <para>Indicates whether the call is successful. true: The call is successful. false: The call has failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
