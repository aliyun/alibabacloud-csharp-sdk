// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class CreateModulePublishResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateModulePublishResponseBodyData Data { get; set; }
        public class CreateModulePublishResponseBodyData : TeaModel {
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

            [NameInMap("PublishId")]
            [Validation(Required=false)]
            public string PublishId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
