// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class BatchQuerySessionByClientIdsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OnlineStatusList")]
        [Validation(Required=false)]
        public List<BatchQuerySessionByClientIdsResponseBodyOnlineStatusList> OnlineStatusList { get; set; }
        public class BatchQuerySessionByClientIdsResponseBodyOnlineStatusList : TeaModel {
            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public bool? OnlineStatus { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

        }

    }

}
