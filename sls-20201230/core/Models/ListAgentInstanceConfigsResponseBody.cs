// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAgentInstanceConfigsResponseBody : TeaModel {
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ListAgentInstanceConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListAgentInstanceConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            [NameInMap("configType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

        }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
