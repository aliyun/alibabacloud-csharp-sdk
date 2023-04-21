// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCdsFileShareLinksRequest : TeaModel {
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        [NameInMap("Creators")]
        [Validation(Required=false)]
        public List<string> Creators { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ShareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("ShareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
