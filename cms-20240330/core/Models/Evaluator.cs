// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Evaluator : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        [NameInMap("dataScope")]
        [Validation(Required=false)]
        public string DataScope { get; set; }

        [NameInMap("filters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Filters { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resultName")]
        [Validation(Required=false)]
        public string ResultName { get; set; }

        [NameInMap("resultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("variableMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> VariableMapping { get; set; }

    }

}
