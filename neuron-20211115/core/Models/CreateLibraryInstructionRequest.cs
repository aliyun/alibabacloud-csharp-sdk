// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class CreateLibraryInstructionRequest : TeaModel {
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

    }

}
