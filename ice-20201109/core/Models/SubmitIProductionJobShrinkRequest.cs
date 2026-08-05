// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitIProductionJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the algorithm function to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: intelligent cover</description></item>
        /// <item><description><b>VideoClip</b>: video synopsis</description></item>
        /// <item><description><b>VideoDelogo</b>: video logo removal</description></item>
        /// <item><description><b>VideoDetext</b>: video subtitle removal</description></item>
        /// <item><description><b>CaptionExtraction</b>: caption extraction</description></item>
        /// <item><description><b>VideoGreenScreenMatting</b>: image matting</description></item>
        /// <item><description><b>FaceBeauty</b>: video face beautification</description></item>
        /// <item><description><b>VideoH2V</b>: intelligent landscape-to-portrait</description></item>
        /// <item><description><b>MusicSegmentDetect</b>: chorus detection</description></item>
        /// <item><description><b>AudioBeatDetection</b>: beat detection</description></item>
        /// <item><description><b>AudioQualityAssessment</b>: audio quality assessment</description></item>
        /// <item><description><b>SpeechDenoise</b>: speech denoising</description></item>
        /// <item><description><b>AudioMixing</b>: audio mixing</description></item>
        /// <item><description><b>MusicDemix</b>: vocal and accompaniment separation</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The input media. Object Storage Service (OSS) paths and media asset IDs are supported.</para>
        /// <para>Different algorithm functions have different input file requirements. For more information, see the supplementary description below.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>The algorithm job parameters. This is a JSON object. The parameters vary depending on the algorithm. For more information, see the supplementary description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Model&quot;:&quot;gif&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The algorithm model ID. If this parameter is left empty, the default model for the corresponding function is used. In most cases, leave this parameter empty to use the default model.</para>
        /// <para>The following algorithm functions have non-default models available:</para>
        /// <list type="bullet">
        /// <item><description>VideoDetext<list type="bullet">
        /// <item><description>ModelId = algo-video-detext-new: a subtitle removal algorithm with better results but slower speed and higher cost than the default algorithm.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The job name. The name can be up to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test task</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output media. OSS paths and media asset IDs are supported.</para>
        /// <para>Different algorithm functions produce different output files. For more information, see the supplementary description below.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string OutputShrink { get; set; }

        /// <summary>
        /// <para>The job scheduling configuration.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public string ScheduleConfigShrink { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The custom user data, which is returned as-is when you retrieve the result. The value can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
