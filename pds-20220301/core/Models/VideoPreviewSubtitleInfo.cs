// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoPreviewSubtitleInfo : TeaModel {
        /// <summary>
        /// <para>The subtitle language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The status of the subtitle task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>finished</description></item>
        /// <item><description>failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>finished</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The subtitle URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.data.aliyunpds.com/lt/A05EF408DAB5D3F57C94F67658C99C406EFCA7DD/subtitle/subtitle_0.vtt">https://example.data.aliyunpds.com/lt/A05EF408DAB5D3F57C94F67658C99C406EFCA7DD/subtitle/subtitle_0.vtt</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
