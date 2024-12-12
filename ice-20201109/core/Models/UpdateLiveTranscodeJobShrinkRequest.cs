// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveTranscodeJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytest3</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The information about the input stream.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public string StreamInputShrink { get; set; }

        /// <summary>
        /// <para>The configuration of a timed transcoding job.</para>
        /// </summary>
        [NameInMap("TimedConfig")]
        [Validation(Required=false)]
        public string TimedConfigShrink { get; set; }

        /// <summary>
        /// <para>The information about the transcoding output.</para>
        /// </summary>
        [NameInMap("TranscodeOutput")]
        [Validation(Required=false)]
        public string TranscodeOutputShrink { get; set; }

    }

}
