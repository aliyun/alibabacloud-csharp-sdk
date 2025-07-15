// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveMPUTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can specify only one application ID. The ID can be up to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID. You can specify only one channel ID. The ID can be up to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The stream mixing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the single-stream relay mode. In this mode, the service only relays the original single stream, but does not transcode mixed streams. You do not need to set parameters for mixed-stream transcoding.</description></item>
        /// <item><description><b>1</b> (default): the mixed-stream relay mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MixMode")]
        [Validation(Required=false)]
        public string MixMode { get; set; }

        /// <summary>
        /// <para>The multiple ingest URLs to relay. This parameter allows you to specify multiple ingest URLs.</para>
        /// </summary>
        [NameInMap("MultiStreamURL")]
        [Validation(Required=false)]
        public string MultiStreamURLShrink { get; set; }

        /// <summary>
        /// <para>The supplemental enhancement information (SEI) parameters.</para>
        /// </summary>
        [NameInMap("SeiParams")]
        [Validation(Required=false)]
        public string SeiParamsShrink { get; set; }

        /// <summary>
        /// <para>The single-stream relay parameters. These parameters are required if you set MixMode to 0.</para>
        /// </summary>
        [NameInMap("SingleSubParams")]
        [Validation(Required=false)]
        public string SingleSubParamsShrink { get; set; }

        /// <summary>
        /// <para>The ingest URL. You can specify only one ingest URL in the Real-Time Messaging Protocol (RTMP) format. The URL can be up to 2,048 characters in length. For information about the generation rules of ingest URLs, see <a href="https://help.aliyun.com/document_detail/199339.html">Ingest and streaming URLs</a>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the ingest URL is under a domain name for which hotlink protection is enabled, you must include an access token in the URL.</description></item>
        /// <item><description>You cannot use the same ingest URL in different tasks.</description></item>
        /// <item><description>You cannot use the same ingest URL within 10 seconds after a task is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://example.com/live/stream</para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>The task ID. You can specify only one task ID. The ID can be up to 55 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The ID must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The mixed-stream relay parameters. These parameters are required if you set MixMode to 1.</para>
        /// </summary>
        [NameInMap("TranscodeParams")]
        [Validation(Required=false)]
        public string TranscodeParamsShrink { get; set; }

    }

}
