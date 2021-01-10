// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ListItemActivitiesRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("LmItemIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> LmItemIds { get; set; }

        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ItemIds { get; set; }

    }

}
