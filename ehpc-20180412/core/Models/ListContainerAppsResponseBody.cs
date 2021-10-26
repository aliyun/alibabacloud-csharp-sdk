// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListContainerAppsResponseBody : TeaModel {
        [NameInMap("ContainerApps")]
        [Validation(Required=false)]
        public ListContainerAppsResponseBodyContainerApps ContainerApps { get; set; }
        public class ListContainerAppsResponseBodyContainerApps : TeaModel {
            [NameInMap("ContainerApps")]
            [Validation(Required=false)]
            public List<ListContainerAppsResponseBodyContainerAppsContainerApps> ContainerApps { get; set; }
            public class ListContainerAppsResponseBodyContainerAppsContainerApps : TeaModel {
                public string CreateTime { get; set; }
                public string Description { get; set; }
                public string Id { get; set; }
                public string ImageTag { get; set; }
                public string Name { get; set; }
                public string Repository { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
