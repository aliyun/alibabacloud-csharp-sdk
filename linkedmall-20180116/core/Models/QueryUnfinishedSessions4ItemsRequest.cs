// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryUnfinishedSessions4ItemsRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ItemIds { get; set; }

        [NameInMap("LmItemIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> LmItemIds { get; set; }

        [NameInMap("QueryTime")]
        [Validation(Required=false)]
        public long? QueryTime { get; set; }

    }

}
