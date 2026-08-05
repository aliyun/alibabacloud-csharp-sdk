// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartLiveMPUTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Only one ID is supported. It can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID. Only one ID is supported. It can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The idle timeout period. Unit: seconds. The value must be in the range of [10, 86400].</para>
        /// <remarks>
        /// <para>If you set this parameter, the task is automatically stopped when it has been idle for a period longer than MaxIdleTime. If you do not set this parameter, the task is stopped immediately after the channel is closed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public string MaxIdleTime { get; set; }

        /// <summary>
        /// <para>The stream mixing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Single-stream ingest. The original single stream is ingested without stream mixing or transcoding. You do not need to configure stream mixing and transcoding parameters.</para>
        /// </description></item>
        /// <item><description><para><b>1</b> (default): Stream mixing and transcoding.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MixMode")]
        [Validation(Required=false)]
        public string MixMode { get; set; }

        /// <summary>
        /// <para>The parameters for ingesting to multiple URLs. You can specify multiple live ingest URLs.</para>
        /// <remarks>
        /// <para>When you set the ingest URL for a task, you must configure either the StreamURL parameter or the MultiStreamURL parameter, but not both.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MultiStreamURL")]
        [Validation(Required=false)]
        public string MultiStreamURLShrink { get; set; }

        /// <summary>
        /// <para>The region where the stream mixing service is located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CN-Shanghai&lt;props=&quot;china&quot;&gt;(default)</b>: Shanghai.</para>
        /// </description></item>
        /// <item><description><para><b>AP-Singapore&lt;props=&quot;intl&quot;&gt;(default)</b>: Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>EMAA-Saudi</b>: Saudi Arabia.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CN-Shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The SEI configuration parameters.</para>
        /// </summary>
        [NameInMap("SeiParams")]
        [Validation(Required=false)]
        public string SeiParamsShrink { get; set; }

        /// <summary>
        /// <para>The parameters for single-stream ingest. This parameter is required when MixMode is set to 0. Do not set this parameter for stream mixing and transcoding.</para>
        /// </summary>
        [NameInMap("SingleSubParams")]
        [Validation(Required=false)]
        public string SingleSubParamsShrink { get; set; }

        /// <summary>
        /// <para>The live ingest URL. Only the RTMP protocol is supported. Only one URL is supported. The maximum length is 2048 characters. For information about how to generate the URL, see <a href="https://help.aliyun.com/document_detail/199339.html">Ingest URLs and playback URLs</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For domain names with hotlink protection enabled, the ingest URL must include an access token.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Do not use the same StreamURL in different tasks at the same time.</para>
        /// </description></item>
        /// <item><description><para>Do not use the same StreamURL within 10 seconds after a task stops.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://example.com/live/stream</para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>The task ID. Only one ID is supported. It can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 55 characters. This ID is the unique identifier for the bypass ingest task.
        /// If a task with the same ID still exists and has not been cleared when you start a new task, \<c>InvalidParam\\</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The parameters for stream mixing and transcoding. This parameter is required when MixMode is set to 1. Do not set this parameter for single-stream ingest.</para>
        /// </summary>
        [NameInMap("TranscodeParams")]
        [Validation(Required=false)]
        public string TranscodeParamsShrink { get; set; }

    }

}
