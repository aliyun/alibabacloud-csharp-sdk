// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodLogsRequest : TeaModel {
        /// <summary>
        /// 是否下载日志文件，默认：false。
        /// </summary>
        [NameInMap("DownloadToFile")]
        [Validation(Required=false)]
        public bool? DownloadToFile { get; set; }

        /// <summary>
        /// 查询的截止时间，默认值：当前。
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 返回的日志的最大行数，默认值：2000。
        /// </summary>
        [NameInMap("MaxLines")]
        [Validation(Required=false)]
        public int? MaxLines { get; set; }

        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        /// <summary>
        /// 查询的起始时间，默认值：7天前。
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
