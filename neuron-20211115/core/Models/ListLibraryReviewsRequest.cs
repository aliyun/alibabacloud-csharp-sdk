// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListLibraryReviewsRequest : TeaModel {
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("reviewer")]
        [Validation(Required=false)]
        public string Reviewer { get; set; }

    }

}
