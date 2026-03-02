// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcApiSchemaCreateCmd : TeaModel {
        [NameInMap("apiSchema")]
        [Validation(Required=false)]
        public string ApiSchema { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("pbcVersionId")]
        [Validation(Required=false)]
        public long? PbcVersionId { get; set; }

    }

}
