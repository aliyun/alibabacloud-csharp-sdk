// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryPageSmartShortUrlLogRequest : TeaModel {
        [NameInMap("ClickState")]
        [Validation(Required=false)]
        public long? ClickState { get; set; }

        [NameInMap("CreateDateEnd")]
        [Validation(Required=false)]
        public long? CreateDateEnd { get; set; }

        [NameInMap("CreateDateStart")]
        [Validation(Required=false)]
        public long? CreateDateStart { get; set; }

        [NameInMap("EndId")]
        [Validation(Required=false)]
        public long? EndId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ShortName")]
        [Validation(Required=false)]
        public string ShortName { get; set; }

        [NameInMap("ShortUrl")]
        [Validation(Required=false)]
        public string ShortUrl { get; set; }

        [NameInMap("StartId")]
        [Validation(Required=false)]
        public long? StartId { get; set; }

    }

}
