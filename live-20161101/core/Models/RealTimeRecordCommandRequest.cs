// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RealTimeRecordCommandRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the stream belongs. You can view the AppName on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The operation action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: forcibly starts recording. This must be called as the first operation and cannot be called again before stopping.</description></item>
        /// <item><description><b>stop</b>: forcibly pauses recording. After the stream interruption delay (180 seconds by default) elapses, a recording is generated. This can only be called after start or restart. To generate the file immediately after calling stop, call cancel_delay.</description></item>
        /// <item><description><b>cancel_delay</b>: immediately terminates the wait and generates a recording, completely stopping recording. This must be called after stop to generate the file in advance.</description></item>
        /// <item><description><b>restart</b>: forcibly restarts recording. If recording is in progress before restart, a file is immediately generated. This can only be called when the task is in the started or stopped state.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The streamer\&quot;s streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The stream name. Make sure that the StreamName is correct. You can view the StreamName on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
        /// <remarks>
        /// <para>This operation supports only single-stream operations and does not support wildcards.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
