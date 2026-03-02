// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class LibraryReviewCreateCmd : TeaModel {
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public long? LibraryId { get; set; }

        [NameInMap("libraryUrl")]
        [Validation(Required=false)]
        public string LibraryUrl { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("reviewerId")]
        [Validation(Required=false)]
        public string ReviewerId { get; set; }

    }

}
