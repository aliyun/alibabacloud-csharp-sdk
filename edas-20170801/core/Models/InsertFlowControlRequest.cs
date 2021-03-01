// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertFlowControlRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ConsumerAppId")]
        [Validation(Required=false)]
        public string ConsumerAppId { get; set; }

        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

        [NameInMap("UrlVar")]
        [Validation(Required=false)]
        public string UrlVar { get; set; }

    }

}
