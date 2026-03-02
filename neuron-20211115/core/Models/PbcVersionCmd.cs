// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcVersionCmd : TeaModel {
        [NameInMap("apiSchema")]
        [Validation(Required=false)]
        public string ApiSchema { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("developerId")]
        [Validation(Required=false)]
        public long? DeveloperId { get; set; }

        [NameInMap("document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
