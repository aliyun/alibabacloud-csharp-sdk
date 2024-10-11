// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Use the multi-application service</a>.</para>
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
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify TranscodeTemplateGroupId or Name in the request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>transcodetemplate</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group. If a transcoding template group ID is specified, you can add transcoding templates to the template group.</para>
        /// <remarks>
        /// <para>You must specify TranscodeTemplateGroupId or Name in the request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4c71a339fe52b4fa6f4527****</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// <para>The configurations of the transcoding template. The value is a string in JSON format. For more information about the data structure, see <a href="https://help.aliyun.com/document_detail/52839.html">TranscodeTemplate</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the transcoding job cannot be automatically created after you upload a video.</description></item>
        /// <item><description>If you do not need to set Width or Height, do not specify the corresponding parameter. You cannot set the value to an empty string, such as &quot;Height&quot;:&quot;&quot;.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Video&quot;:{&quot;Bitrate&quot;:&quot;400&quot;,&quot;Codec&quot;:&quot;H.264&quot;,&quot;Fps&quot;:&quot;30&quot;,&quot;Height&quot;:&quot;&quot;},&quot;Definition&quot;:&quot;SD&quot;,&quot;Container&quot;:{&quot;Format&quot;:&quot;mp4&quot;},&quot;TemplateName&quot;:&quot;testName&quot;,&quot;MuxConfig&quot;:{},&quot;Audio&quot;:{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Bitrate&quot;:&quot;64&quot;,&quot;Samplerate&quot;:&quot;44100&quot;}}]</para>
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
