// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetLevelResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("EnsNetLevels")]
        [Validation(Required=true)]
        public DescribeEnsNetLevelResponseEnsNetLevels EnsNetLevels { get; set; }
        public class DescribeEnsNetLevelResponseEnsNetLevels : TeaModel {
            [NameInMap("EnsNetLevel")]
            [Validation(Required=true)]
            public List<DescribeEnsNetLevelResponseEnsNetLevelsEnsNetLevel> EnsNetLevel { get; set; }
            public class DescribeEnsNetLevelResponseEnsNetLevelsEnsNetLevel : TeaModel {
                public string EnsNetLevelCode { get; set; }
            }
        };

    }

}
