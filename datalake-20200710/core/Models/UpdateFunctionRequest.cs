// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UpdateFunctionRequest : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("FunctionInput")]
        [Validation(Required=false)]
        public FunctionInput FunctionInput { get; set; }

        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
