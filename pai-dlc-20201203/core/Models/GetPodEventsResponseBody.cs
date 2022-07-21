// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodEventsResponseBody : TeaModel {
        /// <summary>
        /// 事件列表
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 运行示例ID
        /// </summary>
        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
