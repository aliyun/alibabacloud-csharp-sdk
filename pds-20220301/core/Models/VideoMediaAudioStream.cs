// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoMediaAudioStream : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>129280</para>
        /// </summary>
        [NameInMap("bit_rate")]
        [Validation(Required=false)]
        public string BitRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aac</para>
        /// </summary>
        [NameInMap("code_name")]
        [Validation(Required=false)]
        public string CodeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7704.573000</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

    }

}
