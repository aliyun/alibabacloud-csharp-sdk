// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListProvisionConfigsOutput : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("provisionConfigs")]
        [Validation(Required=false)]
        public List<ProvisionConfig> ProvisionConfigs { get; set; }

    }

}
