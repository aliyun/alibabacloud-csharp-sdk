// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddMediaConvertTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;AutoStreamName&quot;:&quot;{RunId}_master&quot;}</para>
        /// </summary>
        [NameInMap("GroupConfig")]
        [Validation(Required=false)]
        public string GroupConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mcTemplateGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4c71a339fe52b4fa6f4527****</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Definition&quot;:&quot;HD&quot;,&quot;TemplateName&quot;:&quot;hd-720p&quot;,&quot;Type&quot;:&quot;Normal&quot;,&quot;Video&quot;:{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Bitrate&quot;:&quot;2000&quot;,&quot;Width&quot;:&quot;1280&quot;,&quot;Height&quot;:&quot;720&quot;,&quot;Fps&quot;:&quot;30&quot;},&quot;Audio&quot;:{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Bitrate&quot;:&quot;128&quot;,&quot;Samplerate&quot;:&quot;44100&quot;,&quot;Channels&quot;:&quot;2&quot;},&quot;Container&quot;:{&quot;Format&quot;:&quot;m3u8&quot;},&quot;MuxConfig&quot;:{&quot;Segment&quot;:{&quot;Duration&quot;:&quot;10&quot;}}}]</para>
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
