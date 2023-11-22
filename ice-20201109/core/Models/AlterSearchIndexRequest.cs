// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AlterSearchIndexRequest : TeaModel {
        [NameInMap("IndexConfig")]
        [Validation(Required=false)]
        public string IndexConfig { get; set; }

        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
