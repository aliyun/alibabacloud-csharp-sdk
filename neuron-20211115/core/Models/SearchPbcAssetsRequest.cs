// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class SearchPbcAssetsRequest : TeaModel {
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("page_number")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
