// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class CreateModuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateModuleResponseBodyData Data { get; set; }
        public class CreateModuleResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("LatestPublishedCommit")]
            [Validation(Required=false)]
            public string LatestPublishedCommit { get; set; }

            [NameInMap("LatestPublishedVersion")]
            [Validation(Required=false)]
            public string LatestPublishedVersion { get; set; }

            [NameInMap("MinimumPlatformVersion")]
            [Validation(Required=false)]
            public string MinimumPlatformVersion { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ModuleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("ModuleType")]
            [Validation(Required=false)]
            public string ModuleType { get; set; }

            [NameInMap("OwnerAppId")]
            [Validation(Required=false)]
            public string OwnerAppId { get; set; }

            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("PlatformVersion")]
            [Validation(Required=false)]
            public string PlatformVersion { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
