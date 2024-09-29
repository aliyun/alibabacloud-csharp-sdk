// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateTimingSyntheticTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The struct returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTimingSyntheticTaskResponseBodyData Data { get; set; }
        public class CreateTimingSyntheticTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: The task is in the initial state.</description></item>
            /// <item><description>RELEASE: The task is being parsed.</description></item>
            /// <item><description>RUNNING: The task is running.</description></item>
            /// <item><description>STOP: The task is suspended.</description></item>
            /// <item><description>SYSTEM_STOP: The task is suspended by the system.</description></item>
            /// <item><description>CANCEL: The task is canceled.</description></item>
            /// <item><description>SYSTEM_CANCEL: The task is canceled by the system.</description></item>
            /// <item><description>DONE: The task is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the synthetic monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5308a2691f59422c8c3b7aeccec9cd3b</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
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
        /// <para>53B5874D-EBC1-5567-B787-E4B7267F5CEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
