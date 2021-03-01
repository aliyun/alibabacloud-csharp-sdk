// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertDeployGroupResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("DeployGroupEntity")]
        [Validation(Required=false)]
        public InsertDeployGroupResponseBodyDeployGroupEntity DeployGroupEntity { get; set; }
        public class InsertDeployGroupResponseBodyDeployGroupEntity : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("AppVersionId")]
            [Validation(Required=false)]
            public string AppVersionId { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("PackageVersionId")]
            [Validation(Required=false)]
            public string PackageVersionId { get; set; }
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public int? GroupType { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
        };

    }

}
