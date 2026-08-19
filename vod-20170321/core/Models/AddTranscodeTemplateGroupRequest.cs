// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the transcoding template group.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 128 bytes in length.</description></item>
        /// <item><description>The value is encoded in UTF-8.<remarks>
        /// <para>You must specify either TranscodeTemplateGroupId or Name.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>transcodetemplate</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. If you specify the ID of a transcoding template group, new transcoding templates are added to the specified template group.</para>
        /// <remarks>
        /// <para>You must specify either TranscodeTemplateGroupId or Name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4c71a339fe52b4fa6f4527****</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// <para>The transcoding template configurations in the JSON format. For more information about the parameter structure, see <a href="https://help.aliyun.com/document_detail/52839.html">TranscodeTemplate</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the transcoding process is not created and video uploads do not trigger transcoding.</description></item>
        /// <item><description>If you do not need to set the Width or Height property, do not specify the corresponding property. Do not set it to an empty string, such as &quot;Height&quot;:&quot;&quot;.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Video&quot;:{&quot;Bitrate&quot;:&quot;400&quot;,&quot;Codec&quot;:&quot;H.264&quot;,&quot;Fps&quot;:&quot;30&quot;,&quot;Height&quot;:360,&quot;Width&quot;:640},&quot;Definition&quot;:&quot;SD&quot;,&quot;Container&quot;:{&quot;Format&quot;:&quot;mp4&quot;},&quot;TemplateName&quot;:&quot;testName&quot;,&quot;MuxConfig&quot;:{},&quot;Audio&quot;:{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Bitrate&quot;:&quot;64&quot;,&quot;Samplerate&quot;:&quot;44100&quot;}}]</para>
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
