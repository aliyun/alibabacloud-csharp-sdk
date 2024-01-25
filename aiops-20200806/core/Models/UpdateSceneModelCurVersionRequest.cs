// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateSceneModelCurVersionRequest : TeaModel {
        [NameInMap("ExtId")]
        [Validation(Required=false)]
        public long? ExtId { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
