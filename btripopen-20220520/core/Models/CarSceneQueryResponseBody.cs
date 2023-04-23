// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarSceneQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<CarSceneQueryResponseBodyModule> Module { get; set; }
        public class CarSceneQueryResponseBodyModule : TeaModel {
            [NameInMap("scenarioTemplateId")]
            [Validation(Required=false)]
            public string ScenarioTemplateId { get; set; }

            [NameInMap("scenarioTemplateName")]
            [Validation(Required=false)]
            public string ScenarioTemplateName { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
