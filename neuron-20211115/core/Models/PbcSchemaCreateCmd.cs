// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcSchemaCreateCmd : TeaModel {
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("pbcName")]
        [Validation(Required=false)]
        public string PbcName { get; set; }

        [NameInMap("pbcVersion")]
        [Validation(Required=false)]
        public string PbcVersion { get; set; }

        [NameInMap("schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

    }

}
