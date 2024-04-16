// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListAppModulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAppModulesResponseBodyData Data { get; set; }
        public class ListAppModulesResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListAppModulesResponseBodyDataItems> Items { get; set; }
            public class ListAppModulesResponseBodyDataItems : TeaModel {
                [NameInMap("CommitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DirectDependency")]
                [Validation(Required=false)]
                public bool? DirectDependency { get; set; }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("MinimumPlatformVersion")]
                [Validation(Required=false)]
                public string MinimumPlatformVersion { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public string ModuleId { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
