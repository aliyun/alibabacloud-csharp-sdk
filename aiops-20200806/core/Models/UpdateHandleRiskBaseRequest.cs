// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateHandleRiskBaseRequest : TeaModel {
        [NameInMap("HandleDescribe")]
        [Validation(Required=false)]
        public string HandleDescribe { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("PatrolDetailIds")]
        [Validation(Required=false)]
        public string PatrolDetailIds { get; set; }

        [NameInMap("PatrolId")]
        [Validation(Required=false)]
        public long? PatrolId { get; set; }

    }

}
