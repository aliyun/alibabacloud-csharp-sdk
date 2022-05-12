// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class QueryUnionTaskListRequest : TeaModel {
        [NameInMap("BrandUserId")]
        [Validation(Required=false)]
        public long? BrandUserId { get; set; }

        [NameInMap("BrandUserNick")]
        [Validation(Required=false)]
        public string BrandUserNick { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public long? ProxyUserId { get; set; }

    }

}
