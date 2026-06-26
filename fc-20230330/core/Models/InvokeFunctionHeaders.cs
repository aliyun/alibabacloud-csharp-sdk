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
        /// <para>Asynchronous task ID. Enable asynchronous tasks beforehand.</para>
        /// <remarks>
        /// <para>When using the SDK for invocation, set a business-related ID. This helps with subsequent operations on the execution. For example, a video processing function can use the video filename as the invocation ID. Use this ID to check if the video processing is complete or to stop it. The ID naming convention must start with an English letter (uppercase or lowercase) or an underscore (<em>). It can contain English letters (uppercase or lowercase), digits (0-9), underscores (</em>), and hyphens (-). The ID cannot exceed 128 characters. If you do not set an ID for asynchronous invocation, the system automatically generates one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test-id</para>
        /// </summary>
        [NameInMap("x-fc-async-task-id")]
        [Validation(Required=false)]
        public string XFcAsyncTaskId { get; set; }

        /// <summary>
        /// <para>Function invocation type. Sync or Async.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("x-fc-invocation-type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        /// <summary>
        /// <para>Log type returned by function invocation. None or Tail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tail</para>
        /// </summary>
        [NameInMap("x-fc-log-type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

    }

}
