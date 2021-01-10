// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreOrderRequest : TeaModel {
        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("GmtEnd")]
        [Validation(Required=false)]
        public string GmtEnd { get; set; }

        [NameInMap("GmtStart")]
        [Validation(Required=false)]
        public string GmtStart { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
