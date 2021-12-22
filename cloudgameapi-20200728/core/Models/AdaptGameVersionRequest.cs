/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class AdaptGameVersionRequest : TeaModel {
        /// <summary>
        /// 帧率
        /// </summary>
        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public string FrameRate { get; set; }

        /// <summary>
        /// 分辨率
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// 游戏版本ID
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
