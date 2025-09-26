// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CAPConfig : TeaModel {
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

    }

}
