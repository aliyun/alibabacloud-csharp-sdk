// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTranscodeJobsRequest : TeaModel {
        /// <summary>
        /// 任务创建时间筛选条件的结束时间
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        /// <summary>
        /// 按 jobId 筛选
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 连续分页查询时下一页的标记 (第一页没有)
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// 排序顺序，目前只支持两种：CreateTimeDesc 和 CreateTimeAsc
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 任务创建时间筛选条件的起始时间
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
