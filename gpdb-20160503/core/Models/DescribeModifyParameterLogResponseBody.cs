// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModifyParameterLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Changelogs")]
        [Validation(Required=false)]
        public List<DescribeModifyParameterLogResponseBodyChangelogs> Changelogs { get; set; }
        public class DescribeModifyParameterLogResponseBodyChangelogs : TeaModel {
            [NameInMap("ParameterValueAfter")]
            [Validation(Required=false)]
            public string ParameterValueAfter { get; set; }

            [NameInMap("ParameterValueBefore")]
            [Validation(Required=false)]
            public string ParameterValueBefore { get; set; }

            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            [NameInMap("ParameterValid")]
            [Validation(Required=false)]
            public string ParameterValid { get; set; }

            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

        }

    }

}
