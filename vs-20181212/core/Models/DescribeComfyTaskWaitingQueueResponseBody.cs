// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeComfyTaskWaitingQueueResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 0 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The waiting queue information.</para>
        /// </summary>
        [NameInMap("TaskWaitingQueue")]
        [Validation(Required=false)]
        public DescribeComfyTaskWaitingQueueResponseBodyTaskWaitingQueue TaskWaitingQueue { get; set; }
        public class DescribeComfyTaskWaitingQueueResponseBodyTaskWaitingQueue : TeaModel {
            /// <summary>
            /// <para>The number of waiting tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WaitingCount")]
            [Validation(Required=false)]
            public long? WaitingCount { get; set; }

        }

    }

}
