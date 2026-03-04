// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJobOverwiteParams : TeaModel {
        /// <summary>
        /// <para>Subtitle stream configurations.</para>
        /// </summary>
        [NameInMap("Subtitles")]
        [Validation(Required=false)]
        public List<MediaConvertJobOverwiteParamsSubtitles> Subtitles { get; set; }
        public class MediaConvertJobOverwiteParamsSubtitles : TeaModel {
            /// <summary>
            /// <para>The encoding format for the subtitle stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VTT</para>
            /// </summary>
            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

        }

    }

}
