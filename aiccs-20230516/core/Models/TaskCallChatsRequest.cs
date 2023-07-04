// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskCallChatsRequest : TeaModel {
        /// <summary>
        /// 坐席ID
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// 坐席标签
        /// </summary>
        [NameInMap("AgentTag")]
        [Validation(Required=false)]
        public string AgentTag { get; set; }

        /// <summary>
        /// 外呼ID
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
