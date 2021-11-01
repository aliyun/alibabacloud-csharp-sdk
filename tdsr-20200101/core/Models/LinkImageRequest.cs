// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class LinkImageRequest : TeaModel {
        /// <summary>
        /// 相机高度 单位 cm
        /// </summary>
        [NameInMap("CameraHeight")]
        [Validation(Required=false)]
        public int? CameraHeight { get; set; }

        /// <summary>
        /// 图片或者视频名称xxx.jpg
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// 平台标识，默认PC
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// 子场景ID
        /// </summary>
        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

    }

}
