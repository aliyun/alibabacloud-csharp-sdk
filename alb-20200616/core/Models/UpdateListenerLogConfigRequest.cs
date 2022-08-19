// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerLogConfigRequest : TeaModel {
        [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

        [NameInMap("AccessLogTracingConfig")]
        [Validation(Required=false)]
        public UpdateListenerLogConfigRequestAccessLogTracingConfig AccessLogTracingConfig { get; set; }
        public class UpdateListenerLogConfigRequestAccessLogTracingConfig : TeaModel {
            [NameInMap("TracingEnabled")]
            [Validation(Required=false)]
            public bool? TracingEnabled { get; set; }
            [NameInMap("TracingSample")]
            [Validation(Required=false)]
            public int? TracingSample { get; set; }
            [NameInMap("TracingType")]
            [Validation(Required=false)]
            public string TracingType { get; set; }
        };

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
