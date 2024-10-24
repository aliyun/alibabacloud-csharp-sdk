// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainContractProjectContentTreeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainContractProjectContentTreeResponseBodyResult Result { get; set; }
        public class DescribeAntChainContractProjectContentTreeResponseBodyResult : TeaModel {
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Children { get; set; }

            [NameInMap("ProjectDescription")]
            [Validation(Required=false)]
            public string ProjectDescription { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("ProjectVersion")]
            [Validation(Required=false)]
            public string ProjectVersion { get; set; }

        }

    }

}
