// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class TracingConfig : TeaModel {
        /// <summary>
        /// 链路追踪参数。当协议类型为 Jaeger 时，参数为 map[string]string，其中 key 为 "endpoint"，value 为您的链路追踪内网接入点。例如 endpoint: http://tracing-analysis-dc-hz.aliyuncs.com/adapt_xxx/api/otlp/traces
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// 链路追踪协议类型，目前只支持 Jaeger
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
