// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionInstancesRequest : TeaModel {
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
