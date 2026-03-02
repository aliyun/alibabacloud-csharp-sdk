// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class Provider : TeaModel {
        [NameInMap("company")]
        [Validation(Required=false)]
        public string Company { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("team")]
        [Validation(Required=false)]
        public string Team { get; set; }

        [NameInMap("teamId")]
        [Validation(Required=false)]
        public long? TeamId { get; set; }

    }

}
