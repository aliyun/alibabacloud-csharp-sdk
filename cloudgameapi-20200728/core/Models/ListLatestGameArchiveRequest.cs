// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListLatestGameArchiveRequest : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TagStatus")]
        [Validation(Required=false)]
        public long? TagStatus { get; set; }

    }

}
