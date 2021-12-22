// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListHistoryContainerStatusRequest : TeaModel {
        /// <summary>
        /// 结束时间（Linux时间戳，单位毫秒）
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 上一个游戏会话ID
        /// </summary>
        [NameInMap("LastGameSessionId")]
        [Validation(Required=false)]
        public string LastGameSessionId { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 开始时间（Linux时间戳，单位毫秒）
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
