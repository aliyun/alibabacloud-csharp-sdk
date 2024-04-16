// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListModulePublishVersionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListModulePublishVersionsResponseBodyData Data { get; set; }
        public class ListModulePublishVersionsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListModulePublishVersionsResponseBodyDataItems> Items { get; set; }
            public class ListModulePublishVersionsResponseBodyDataItems : TeaModel {
                [NameInMap("CommitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public string ModuleId { get; set; }

                [NameInMap("PlatformVersion")]
                [Validation(Required=false)]
                public string PlatformVersion { get; set; }

                [NameInMap("PublishId")]
                [Validation(Required=false)]
                public string PublishId { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
