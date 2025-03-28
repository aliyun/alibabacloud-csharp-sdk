// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EnvironmentStagedConfigs : TeaModel {
        [NameInMap("services")]
        [Validation(Required=false)]
        public Dictionary<string, ServiceConfig> Services { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, Variable> Variables { get; set; }

    }

}
