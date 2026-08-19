// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The lock state of the template group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: locked. A locked template group cannot be modified.</description></item>
        /// <item><description><b>Disabled</b> (default): unlocked.</description></item>
        /// </list>
        /// <para>Default value: <b>Disabled</b>. If you specify this parameter, the lock state of the template group is changed, while the name and configurations of the transcoding template group remain unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("Locked")]
        [Validation(Required=false)]
        public string Locked { get; set; }

        /// <summary>
        /// <para>The name of the transcoding template group.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 128 bytes in length.</description></item>
        /// <item><description>The name is encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>transcodetemplate</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c71a339fe*****52b4fa6f4527</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// <para>The transcoding template configurations (a JSON string). For more information about the parameter structure, see <a href="~~52839#title-9mb-8o2-uu6~~">TranscodeTemplate</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Video&quot;:{&quot;Bitrate&quot;:&quot;400&quot;,&quot;Codec&quot;:&quot;H.264&quot;,&quot;Fps&quot;:&quot;30&quot;},&quot;Audio&quot;:{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Bitrate&quot;:&quot;64&quot;,&quot;Definition&quot;:&quot;SD&quot;,&quot;EncryptType&quot;:&quot;Private&quot;,&quot;Container&quot;:{&quot;Format&quot;:&quot;m3u8&quot;},&quot;PackageType&quot;:&quot;HLSPackage&quot;}}]</para>
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
