// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class BaiLianAgentTransformParameters : TeaModel {
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public BaiLianAgentTransformParametersPrompt Prompt { get; set; }
        public class BaiLianAgentTransformParametersPrompt : TeaModel {
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

        [NameInMap("RequestPerMinute")]
        [Validation(Required=false)]
        public long? RequestPerMinute { get; set; }

        [NameInMap("TokenPerMinute")]
        [Validation(Required=false)]
        public long? TokenPerMinute { get; set; }

    }

}
