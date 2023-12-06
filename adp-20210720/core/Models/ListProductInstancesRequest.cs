// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductInstancesRequest : TeaModel {
        [NameInMap("envUID")]
        [Validation(Required=false)]
        public string EnvUID { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public ListProductInstancesRequestOptions Options { get; set; }
        public class ListProductInstancesRequestOptions : TeaModel {
            [NameInMap("filterWithSpecUID")]
            [Validation(Required=false)]
            public bool? FilterWithSpecUID { get; set; }

            [NameInMap("specUID")]
            [Validation(Required=false)]
            public string SpecUID { get; set; }

        }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
