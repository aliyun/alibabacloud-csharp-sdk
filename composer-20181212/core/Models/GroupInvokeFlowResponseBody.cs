// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GroupInvokeFlowResponseBody : TeaModel {
        /// <summary>
        /// 当前批次
        /// </summary>
        [NameInMap("CurrentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// 执行 ID
        /// </summary>
        [NameInMap("GroupInvocationId")]
        [Validation(Required=false)]
        public string GroupInvocationId { get; set; }

        /// <summary>
        /// 请求 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
