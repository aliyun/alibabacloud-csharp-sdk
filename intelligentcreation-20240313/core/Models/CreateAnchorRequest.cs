// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAnchorRequest : TeaModel {
        [NameInMap("anchorCategory")]
        [Validation(Required=false)]
        public string AnchorCategory { get; set; }

        [NameInMap("anchorMaterialName")]
        [Validation(Required=false)]
        public string AnchorMaterialName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://yic-pre.oss-cn-hangzhou.aliyuncs.com/common/image/anchor/1733474220549-1733474198960image.png?Expires=3311144948&OSSAccessKeyId=LTAI5tPHLyFPhh4UoRias4Zg&Signature=qldDufvRDj9IUTmOtb9r2451RIU%3D">https://yic-pre.oss-cn-hangzhou.aliyuncs.com/common/image/anchor/1733474220549-1733474198960image.png?Expires=3311144948&amp;OSSAccessKeyId=LTAI5tPHLyFPhh4UoRias4Zg&amp;Signature=qldDufvRDj9IUTmOtb9r2451RIU%3D</a></para>
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

        [NameInMap("videoOssKey")]
        [Validation(Required=false)]
        public string VideoOssKey { get; set; }

    }

}
