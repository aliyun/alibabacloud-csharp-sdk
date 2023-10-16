// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryMaterialRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("QueryUnconfirmedInfo")]
        [Validation(Required=false)]
        public bool? QueryUnconfirmedInfo { get; set; }

    }

}
