// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CallChainInfo : TeaModel {
        [NameInMap("AdditionalInfo")]
        [Validation(Required=false)]
        public string AdditionalInfo { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<CallChainInfo> Children { get; set; }

        [NameInMap("HaveSpan")]
        [Validation(Required=false)]
        public bool? HaveSpan { get; set; }

        [NameInMap("LogMap")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> LogMap { get; set; }

        [NameInMap("LogTime")]
        [Validation(Required=false)]
        public long? LogTime { get; set; }

        [NameInMap("ParentSpanId")]
        [Validation(Required=false)]
        public string ParentSpanId { get; set; }

        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Rpc")]
        [Validation(Required=false)]
        public string Rpc { get; set; }

        [NameInMap("RpcId")]
        [Validation(Required=false)]
        public string RpcId { get; set; }

        [NameInMap("RpcType")]
        [Validation(Required=false)]
        public long? RpcType { get; set; }

        [NameInMap("ServerIp")]
        [Validation(Required=false)]
        public string ServerIp { get; set; }

        [NameInMap("Span")]
        [Validation(Required=false)]
        public long? Span { get; set; }

        [NameInMap("SpanId")]
        [Validation(Required=false)]
        public string SpanId { get; set; }

        [NameInMap("TagMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> TagMap { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
