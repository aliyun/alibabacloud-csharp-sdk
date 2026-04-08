// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsConfig : TeaModel {
        [NameInMap("logRequestContent")]
        [Validation(Required=false)]
        public bool? LogRequestContent { get; set; }

        [NameInMap("logResponseContent")]
        [Validation(Required=false)]
        public bool? LogResponseContent { get; set; }

        [NameInMap("pathFieldConfigs")]
        [Validation(Required=false)]
        public List<AiStatisticsConfigPathFieldConfigs> PathFieldConfigs { get; set; }
        public class AiStatisticsConfigPathFieldConfigs : TeaModel {
            [NameInMap("fieldPaths")]
            [Validation(Required=false)]
            public Dictionary<string, AiStatisticsPathField> FieldPaths { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

    }

}
