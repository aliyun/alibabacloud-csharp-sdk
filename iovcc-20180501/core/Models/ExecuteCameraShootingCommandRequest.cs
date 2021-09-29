// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ExecuteCameraShootingCommandRequest : TeaModel {
        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 终端设备id
        /// </summary>
        [NameInMap("EdgeDeviceId")]
        [Validation(Required=false)]
        public string EdgeDeviceId { get; set; }

        /// <summary>
        /// 拍摄类型，0-图片，1-视频
        /// </summary>
        [NameInMap("ShootingType")]
        [Validation(Required=false)]
        public long? ShootingType { get; set; }

        /// <summary>
        /// 拍摄数量
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public long? Number { get; set; }

        /// <summary>
        /// 拍照间隔/视频时长，单位为s
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

    }

}
