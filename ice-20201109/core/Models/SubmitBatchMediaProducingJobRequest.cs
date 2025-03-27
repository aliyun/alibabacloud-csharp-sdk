// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitBatchMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The editing configurations. For more information, see <a href="~~2692547#1be9bba03b7qu~~">EditingConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaConfig&quot;: {
        ///       &quot;Volume&quot;: 0
        ///   },
        ///   &quot;SpeechConfig&quot;: {
        ///       &quot;Volume&quot;: 1
        ///   },
        ///  &quot;BackgroundMusicConfig&quot;: {
        ///       &quot;Volume&quot;: 0.3
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input configurations. For more information, see <a href="~~2692547#2faed1559549n~~">InputConfig</a>.</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output configurations. For more information, see <a href="~~2692547#447b928fcbuoa~~">OutputConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
        ///   &quot;Count&quot;: 20,
        ///   &quot;MaxDuration&quot;: 15,
        ///   &quot;Width&quot;: 1080,
        ///   &quot;Height&quot;: 1920,
        ///   &quot;Video&quot;: {&quot;Crf&quot;: 27}
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The user-defined data, including the business and callback configurations. For more information, see <a href="https://help.aliyun.com/document_detail/357745.html">UserData</a>.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
