// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobEventsResponseBody : TeaModel {
        /// <summary>
        /// 事件
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
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public int? RequestId { get; set; }

    }

}
