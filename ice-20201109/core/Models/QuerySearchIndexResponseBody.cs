// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySearchIndexResponseBody : TeaModel {
        [NameInMap("IndexConfig")]
        [Validation(Required=false)]
        public string IndexConfig { get; set; }

        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
