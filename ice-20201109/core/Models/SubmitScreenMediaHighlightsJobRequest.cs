// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitScreenMediaHighlightsJobRequest : TeaModel {
        /// <summary>
        /// <para>The editing configuration. For detailed parameters, see <a href="~~2863940#9b05519d46e0x~~">EditingConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;MediaConfig&quot;: {
        ///         &quot;Volume&quot;: 1
        ///     },
        ///     &quot;ProcessConfig&quot;: {
        ///         &quot;AllowTransition&quot;: true,
        ///         &quot;TransitionList&quot;: [&quot;fadecolor&quot;]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input configuration. For detailed parameters, see <a href="~~2863940#dda38bf6ec2pk~~">InputConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;MediaArray&quot;: [
        ///         &quot;<b><b>9d46c886b45481030f6e</b></b>&quot;,
        ///         &quot;<b><b>6c886b4549d481030f6e</b></b>&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output configuration. For detailed parameters, see <a href="~~2863940#4111a373d0xbz~~">OutputConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
        ///   &quot;Count&quot;: 1,
        ///   &quot;Width&quot;: 1080,
        ///   &quot;Height&quot;: 1920
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The user-defined data, including the business and callback configurations. For more information, see <a href="https://help.aliyun.com/document_detail/357745.html">UserData</a>.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
