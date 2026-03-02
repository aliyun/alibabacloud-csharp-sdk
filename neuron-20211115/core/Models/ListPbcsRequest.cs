// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListPbcsRequest : TeaModel {
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("developerId")]
        [Validation(Required=false)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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

    }

}
