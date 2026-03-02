// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListEnvInfosRequest : TeaModel {
        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
