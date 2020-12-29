// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class CreateAntChainContractContentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateAntChainContractContentResponseBodyResult Result { get; set; }
        public class CreateAntChainContractContentResponseBodyResult : TeaModel {
            [NameInMap("ContentName")]
            [Validation(Required=false)]
            public string ContentName { get; set; }
            [NameInMap("ParentContentId")]
            [Validation(Required=false)]
            public string ParentContentId { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("IsDirectory")]
            [Validation(Required=false)]
            public bool? IsDirectory { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }
        };

    }

}
