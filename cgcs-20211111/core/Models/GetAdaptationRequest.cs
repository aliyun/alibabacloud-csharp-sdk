// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class GetAdaptationRequest : TeaModel {
        [NameInMap("AdaptApplyId")]
        [Validation(Required=false)]
        public long? AdaptApplyId { get; set; }

        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

    }

}
