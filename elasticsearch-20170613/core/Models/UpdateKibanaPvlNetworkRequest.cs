// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaPvlNetworkRequest : TeaModel {
        [NameInMap("endpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        [NameInMap("securityGroups")]
        [Validation(Required=false)]
        public List<string> SecurityGroups { get; set; }

        [NameInMap("pvlId")]
        [Validation(Required=false)]
        public string PvlId { get; set; }

    }

}
