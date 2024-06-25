// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskCallListRequest : TeaModel {
        /// <summary>
        /// 导入号码时返回的批次号
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// 开始外呼时间
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CallDate")]
        [Validation(Required=false)]
        public string CallDate { get; set; }

        /// <summary>
        /// 结束外呼时间
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndCallDate")]
        [Validation(Required=false)]
        public string EndCallDate { get; set; }

        /// <summary>
        /// 意向标签
        /// </summary>
        [NameInMap("IntentTags")]
        [Validation(Required=false)]
        public List<string> IntentTags { get; set; }

        /// <summary>
        /// 号码列表
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public List<string> Numbers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 页数
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// 每页外呼记录数,正整数，默认10000
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
        /// 任务ID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
