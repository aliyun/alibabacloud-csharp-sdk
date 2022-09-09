// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListRelationModulesResponseBody : TeaModel {
        [NameInMap("modules")]
        [Validation(Required=false)]
        public List<ListRelationModulesResponseBodyModules> Modules { get; set; }
        public class ListRelationModulesResponseBodyModules : TeaModel {
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
