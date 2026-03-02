// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListPbcReviewsRequest : TeaModel {
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public int? OrderBy { get; set; }

        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public int? OrderDirection { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("reviewer")]
        [Validation(Required=false)]
        public string Reviewer { get; set; }

    }

}
