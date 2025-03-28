// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EnvironmentSnapshot : TeaModel {
        [NameInMap("services")]
        [Validation(Required=false)]
        public Dictionary<string, ServiceInstance> Services { get; set; }

    }

}
