// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModifyParameterLogResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Changelogs")]
        [Validation(Required=true)]
        public List<DescribeModifyParameterLogResponseChangelogs> Changelogs { get; set; }
        public class DescribeModifyParameterLogResponseChangelogs : TeaModel {
            [NameInMap("ParameterName")]
            [Validation(Required=true)]
            public string ParameterName { get; set; }

            [NameInMap("ParameterValueBefore")]
            [Validation(Required=true)]
            public string ParameterValueBefore { get; set; }

            [NameInMap("ParameterValueAfter")]
            [Validation(Required=true)]
            public string ParameterValueAfter { get; set; }

            [NameInMap("ParameterValid")]
            [Validation(Required=true)]
            public string ParameterValid { get; set; }

            [NameInMap("EffectTime")]
            [Validation(Required=true)]
            public string EffectTime { get; set; }

        }

    }

}
