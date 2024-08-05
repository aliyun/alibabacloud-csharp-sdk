// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListEngineConfigsResponseBody : TeaModel {
        [NameInMap("EngineConfigs")]
        [Validation(Required=false)]
        public List<ListEngineConfigsResponseBodyEngineConfigs> EngineConfigs { get; set; }
        public class ListEngineConfigsResponseBodyEngineConfigs : TeaModel {
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            [NameInMap("EngineConfigId")]
            [Validation(Required=false)]
            public string EngineConfigId { get; set; }

            [NameInMap("Environment")]
            [Validation(Required=false)]
            public string Environment { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("GmtReleasedTime")]
            [Validation(Required=false)]
            public string GmtReleasedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
