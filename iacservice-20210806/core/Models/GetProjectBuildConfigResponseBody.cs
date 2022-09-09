// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProjectBuildConfigResponseBody : TeaModel {
        [NameInMap("projectBuildConfig")]
        [Validation(Required=false)]
        public GetProjectBuildConfigResponseBodyProjectBuildConfig ProjectBuildConfig { get; set; }
        public class GetProjectBuildConfigResponseBodyProjectBuildConfig : TeaModel {
            [NameInMap("taskPolicies")]
            [Validation(Required=false)]
            public Dictionary<string, ProjectBuildConfigTaskPoliciesValue> TaskPolicies { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
