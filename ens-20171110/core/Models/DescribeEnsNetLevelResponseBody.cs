// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetLevelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EnsNetLevels")]
        [Validation(Required=false)]
        public DescribeEnsNetLevelResponseBodyEnsNetLevels EnsNetLevels { get; set; }
        public class DescribeEnsNetLevelResponseBodyEnsNetLevels : TeaModel {
            [NameInMap("EnsNetLevel")]
            [Validation(Required=false)]
            public List<DescribeEnsNetLevelResponseBodyEnsNetLevelsEnsNetLevel> EnsNetLevel { get; set; }
            public class DescribeEnsNetLevelResponseBodyEnsNetLevelsEnsNetLevel : TeaModel {
                [NameInMap("EnsNetLevelCode")]
                [Validation(Required=false)]
                public string EnsNetLevelCode { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
