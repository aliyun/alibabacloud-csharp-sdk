// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestNetworkConnectionResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=true)]
        public TestNetworkConnectionResponseTaskList TaskList { get; set; }
        public class TestNetworkConnectionResponseTaskList : TeaModel {
            [NameInMap("ConnectStatus")]
            [Validation(Required=true)]
            public bool? ConnectStatus { get; set; }
            [NameInMap("ConnectMessage")]
            [Validation(Required=true)]
            public string ConnectMessage { get; set; }
        };

    }

}
