// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class InvokeFunctionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("X-Fc-Account-Id")]
        [Validation(Required=false)]
        public string XFcAccountId { get; set; }

        /// <summary>
        /// 调用方式:Sync或者Async，默认值：Sync
        /// </summary>
        [NameInMap("x-fc-invocation-type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        /// <summary>
        /// 请求返回日志类型, Tail 为返回函数日志最后 4KB 数据，None 或空值则返回不带有日志，默认为 None
        /// </summary>
        [NameInMap("x-fc-log-type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

        [NameInMap("x-fc-stateful-async-invocation-id")]
        [Validation(Required=false)]
        public string XFcStatefulAsyncInvocationId { get; set; }

    }

}
