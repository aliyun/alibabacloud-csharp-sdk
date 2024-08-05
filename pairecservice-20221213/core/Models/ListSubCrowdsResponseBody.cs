// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListSubCrowdsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCrowds")]
        [Validation(Required=false)]
        public List<ListSubCrowdsResponseBodySubCrowds> SubCrowds { get; set; }
        public class ListSubCrowdsResponseBodySubCrowds : TeaModel {
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SubCrowdId")]
            [Validation(Required=false)]
            public string SubCrowdId { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public string Users { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
