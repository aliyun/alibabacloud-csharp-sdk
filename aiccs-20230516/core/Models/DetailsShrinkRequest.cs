// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class DetailsShrinkRequest : TeaModel {
        /// <summary>
        /// 批次id
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// 结束导入时间
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 号码状态
        /// </summary>
        [NameInMap("NumberStatus")]
        [Validation(Required=false)]
        public long? NumberStatus { get; set; }

        /// <summary>
        /// 号码列表
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public string NumbersShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 开始导入时间
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
