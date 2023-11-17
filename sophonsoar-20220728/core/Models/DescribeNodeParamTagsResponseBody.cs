// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeNodeParamTagsResponseBody : TeaModel {
        [NameInMap("ParamReferredPaths")]
        [Validation(Required=false)]
        public List<DescribeNodeParamTagsResponseBodyParamReferredPaths> ParamReferredPaths { get; set; }
        public class DescribeNodeParamTagsResponseBodyParamReferredPaths : TeaModel {
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

            [NameInMap("ReferredPath")]
            [Validation(Required=false)]
            public List<string> ReferredPath { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
