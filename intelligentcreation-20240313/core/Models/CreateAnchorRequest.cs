// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAnchorRequest : TeaModel {
        /// <summary>
        /// <para>类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIDEO_ANCHOR</para>
        /// </summary>
        [NameInMap("anchorCategory")]
        [Validation(Required=false)]
        public string AnchorCategory { get; set; }

        [NameInMap("anchorMaterialName")]
        [Validation(Required=false)]
        public string AnchorMaterialName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx">https://xxx</a></para>
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("digitalHumanType")]
        [Validation(Required=false)]
        public string DigitalHumanType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>offlineSynthesis</para>
        /// </summary>
        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        /// <summary>
        /// <para>视频文件osskey</para>
        /// 
        /// <b>Example:</b>
        /// <para>path/key.mp4</para>
        /// </summary>
        [NameInMap("videoOssKey")]
        [Validation(Required=false)]
        public string VideoOssKey { get; set; }

    }

}
