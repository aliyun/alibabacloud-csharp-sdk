// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetNodeConfigResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetNodeConfigResponseBodyResult Result { get; set; }
        public class GetNodeConfigResponseBodyResult : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("dataDuplicateNumber")]
            [Validation(Required=false)]
            public int? DataDuplicateNumber { get; set; }

            [NameInMap("dataFragmentNumber")]
            [Validation(Required=false)]
            public int? DataFragmentNumber { get; set; }

            [NameInMap("minServicePercent")]
            [Validation(Required=false)]
            public int? MinServicePercent { get; set; }

            [NameInMap("published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

        }

    }

}
