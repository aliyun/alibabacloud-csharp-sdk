// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SearchBodyTraceRequest : TeaModel {
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<SearchBodyTraceRequestImages> Images { get; set; }
        public class SearchBodyTraceRequestImages : TeaModel {
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public byte[] ImageData { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("MinScore")]
        [Validation(Required=false)]
        public float? MinScore { get; set; }

    }

}
