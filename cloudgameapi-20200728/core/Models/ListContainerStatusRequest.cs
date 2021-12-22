// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListContainerStatusRequest : TeaModel {
        [NameInMap("GameSessionIdList")]
        [Validation(Required=false)]
        public List<ListContainerStatusRequestGameSessionIdList> GameSessionIdList { get; set; }
        public class ListContainerStatusRequestGameSessionIdList : TeaModel {
            [NameInMap("GameSessionId")]
            [Validation(Required=false)]
            public string GameSessionId { get; set; }

        }

    }

}
