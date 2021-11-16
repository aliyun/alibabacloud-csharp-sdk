// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestNetworkConnectionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public TestNetworkConnectionResponseBodyTaskList TaskList { get; set; }
        public class TestNetworkConnectionResponseBodyTaskList : TeaModel {
            [NameInMap("ConnectMessage")]
            [Validation(Required=false)]
            public string ConnectMessage { get; set; }
            [NameInMap("ConnectStatus")]
            [Validation(Required=false)]
            public bool? ConnectStatus { get; set; }
        };

    }

}
