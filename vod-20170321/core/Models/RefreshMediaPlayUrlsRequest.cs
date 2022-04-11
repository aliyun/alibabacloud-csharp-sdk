// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsRequest : TeaModel {
        /// <summary>
        /// 播放流清晰度
        /// </summary>
        [NameInMap("Definitions")]
        [Validation(Required=false)]
        public string Definitions { get; set; }

        /// <summary>
        /// 播放流格式
        /// </summary>
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public string Formats { get; set; }

        /// <summary>
        /// 媒资ID列表
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// 结果类型：Single或Multiple
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// M3U8文件的ts链接数量
        /// </summary>
        [NameInMap("SliceCount")]
        [Validation(Required=false)]
        public int? SliceCount { get; set; }

        /// <summary>
        /// M3U8文件是否获取ts链接
        /// </summary>
        [NameInMap("SliceFlag")]
        [Validation(Required=false)]
        public bool? SliceFlag { get; set; }

        /// <summary>
        /// 播放流类型：视频或音频
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// Refresh: 刷新。Preload: 预热
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// 回调设置
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
