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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Repository")]
                [Validation(Required=false)]
                public string Repository { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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
