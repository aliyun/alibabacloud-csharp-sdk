// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVideoIPCObjectAdvanceRequest : TeaModel {
        [NameInMap("VideoURLObject")]
        [Validation(Required=true)]
        public Stream VideoURLObject { get; set; }

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

    }

}
