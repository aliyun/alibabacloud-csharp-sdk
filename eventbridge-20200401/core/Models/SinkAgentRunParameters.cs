// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkAgentRunParameters : TeaModel {
        [NameInMap("AgentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public SinkAgentRunParametersBody Body { get; set; }
        public class SinkAgentRunParametersBody : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public string Timeout { get; set; }

    }

}
