// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryOutboundJobsShrinkRequest : TeaModel {
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("SaasId")]
        [Validation(Required=false)]
        public string SaasId { get; set; }

        [NameInMap("ShopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("UserProfile")]
        [Validation(Required=false)]
        public string UserProfileShrink { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
