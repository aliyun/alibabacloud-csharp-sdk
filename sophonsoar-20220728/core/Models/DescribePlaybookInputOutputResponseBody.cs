// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookInputOutputResponseBody : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribePlaybookInputOutputResponseBodyConfig Config { get; set; }
        public class DescribePlaybookInputOutputResponseBodyConfig : TeaModel {
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            [NameInMap("OutputParams")]
            [Validation(Required=false)]
            public string OutputParams { get; set; }

            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
