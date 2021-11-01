// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class PredictionWallLineRequest : TeaModel {
        /// <summary>
        /// 相机高度 单位 cm
        /// </summary>
        [NameInMap("CameraHeight")]
        [Validation(Required=false)]
        public long? CameraHeight { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
