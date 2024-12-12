// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveTranscodeJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the transcoding job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The start mode of the transcoding job.</para>
        /// <list type="bullet">
        /// <item><description>0: The transcoding job immediately starts.</description></item>
        /// <item><description>1: The transcoding job starts at the scheduled time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartMode")]
        [Validation(Required=false)]
        public int? StartMode { get; set; }

        /// <summary>
        /// <para>The information about the input stream.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public string StreamInputShrink { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The configuration of a timed transcoding job. This parameter is required if you set StartMode to 1.</para>
        /// </summary>
        [NameInMap("TimedConfig")]
        [Validation(Required=false)]
        public string TimedConfigShrink { get; set; }

        /// <summary>
        /// <para>The information about the transcoding output.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TranscodeOutput")]
        [Validation(Required=false)]
        public string TranscodeOutputShrink { get; set; }

    }

}
