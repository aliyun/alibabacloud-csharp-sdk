// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class StartUserGameShrinkRequest : TeaModel {
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfoShrink { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

        [NameInMap("UserApp")]
        [Validation(Required=false)]
        public string UserApp { get; set; }

    }

}
