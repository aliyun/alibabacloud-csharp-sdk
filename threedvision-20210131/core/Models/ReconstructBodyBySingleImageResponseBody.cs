// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class ReconstructBodyBySingleImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReconstructBodyBySingleImageResponseBodyData Data { get; set; }
        public class ReconstructBodyBySingleImageResponseBodyData : TeaModel {
            [NameInMap("DepthURL")]
            [Validation(Required=false)]
            public string DepthURL { get; set; }

            [NameInMap("MeshURL")]
            [Validation(Required=false)]
            public string MeshURL { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
