// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InvokeFunctionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous task. You must enable asynchronous tasks in advance.</para>
        /// <remarks>
        /// <para>We recommend that you set a business-related ID when you use the SDK to invoke the function, which facilitates subsequent operations on the execution. For example, a video processing function can use the video file name as the invoke ID, through which you can check whether the video processing is complete or stop the video processing. The ID must start with an uppercase or lowercase letter or an underscore (<em>), and can contain uppercase and lowercase letters, digits (0-9), underscores (</em>), and hyphens (-). It can be up to 128 characters in length. If you do not specify an ID for the asynchronous invoke, the system automatically generates one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test-id</para>
        /// </summary>
        [NameInMap("x-fc-async-task-id")]
        [Validation(Required=false)]
        public string XFcAsyncTaskId { get; set; }

        /// <summary>
        /// <para>The function invoke type. Valid values: Sync and Async.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("x-fc-invocation-type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        /// <summary>
        /// <para>The log type returned for function invoke. Valid values: None and Tail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tail</para>
        /// </summary>
        [NameInMap("x-fc-log-type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

    }

}
