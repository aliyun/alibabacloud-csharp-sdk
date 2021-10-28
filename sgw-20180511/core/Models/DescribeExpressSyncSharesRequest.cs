// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeExpressSyncSharesRequest : TeaModel {
        [NameInMap("ExpressSyncIds")]
        [Validation(Required=false)]
        public string ExpressSyncIds { get; set; }

        [NameInMap("IsExternal")]
        [Validation(Required=false)]
        public bool? IsExternal { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
