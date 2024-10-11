// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The lock status of the transcoding template group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: The transcoding template group is locked and cannot be modified.</description></item>
        /// <item><description><b>Disabled</b> (default): The transcoding template group is not locked.</description></item>
        /// </list>
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
        /// <item><description>The name cannot exceed 128 bytes.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
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
        /// <para>The configurations of the transcoding template. The value must be a JSON string. For more information about the data structure, see <a href="~~52839#title-9mb-8o2-uu6~~">TranscodeTemplate</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Video&quot;:{&quot;Bitrate&quot;:&quot;400&quot;,&quot;Codec&quot;:&quot;H.264&quot;,&quot;Fps&quot;:&quot;30&quot;},&quot;Audio&quot;:{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Bitrate&quot;:&quot;64&quot;,&quot;Definition&quot;:&quot;SD&quot;,&quot;EncryptType&quot;:&quot;Private&quot;,&quot;Container&quot;:{&quot;Format&quot;:&quot;m3u8&quot;},&quot;PackageType&quot;:&quot;HLSPackage&quot;}}]</para>
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
