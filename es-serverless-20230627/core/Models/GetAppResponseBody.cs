// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetAppResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAppResponseBodyResult Result { get; set; }
        public class GetAppResponseBodyResult : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
