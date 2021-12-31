// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionCurrentVersionRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

    }

}
