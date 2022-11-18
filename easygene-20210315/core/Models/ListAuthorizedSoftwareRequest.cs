// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListAuthorizedSoftwareRequest : TeaModel {
        [NameInMap("IsReversed")]
        [Validation(Required=false)]
        public bool? IsReversed { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

    }

}
