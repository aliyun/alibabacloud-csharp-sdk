// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsSgCircuitBreakerRuleRequest : TeaModel {
        [NameInMap("AppNames")]
        [Validation(Required=false)]
        public string AppNames { get; set; }

        [NameInMap("CircuitBreakerRuleItems")]
        [Validation(Required=false)]
        public string CircuitBreakerRuleItems { get; set; }

        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("HttpMethod")]
        [Validation(Required=false)]
        public string HttpMethod { get; set; }

        [NameInMap("HttpPath")]
        [Validation(Required=false)]
        public string HttpPath { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("ResType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
