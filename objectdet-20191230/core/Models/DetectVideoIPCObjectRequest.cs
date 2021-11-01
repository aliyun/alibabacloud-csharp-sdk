// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVideoIPCObjectRequest : TeaModel {
        /// <summary>
        /// 是否只有检测到物体才回调
        /// </summary>
        [NameInMap("CallbackOnlyHasObject")]
        [Validation(Required=false)]
        public bool? CallbackOnlyHasObject { get; set; }

        /// <summary>
        /// 视频的开始时间戳(秒)，即UTC时间，默认为0
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 视频文件URL地址
        /// </summary>
        [NameInMap("VideoURL")]
        [Validation(Required=false)]
        public string VideoURL { get; set; }

    }

}
