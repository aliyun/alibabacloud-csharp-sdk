// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeContainerAppResponseBody : TeaModel {
        [NameInMap("ContainerAppInfo")]
        [Validation(Required=false)]
        public DescribeContainerAppResponseBodyContainerAppInfo ContainerAppInfo { get; set; }
        public class DescribeContainerAppResponseBodyContainerAppInfo : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
