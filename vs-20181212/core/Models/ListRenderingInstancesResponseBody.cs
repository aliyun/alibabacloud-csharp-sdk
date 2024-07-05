// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingInstancesResponseBody : TeaModel {
        [NameInMap("RenderingInstances")]
        [Validation(Required=false)]
        public List<ListRenderingInstancesResponseBodyRenderingInstances> RenderingInstances { get; set; }
        public class ListRenderingInstancesResponseBodyRenderingInstances : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            [NameInMap("RenderingSpec")]
            [Validation(Required=false)]
            public string RenderingSpec { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
