// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListContainerStatusResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListContainerStatusResponseBodyDataList> DataList { get; set; }
        public class ListContainerStatusResponseBodyDataList : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("ContainerQuitTime")]
            [Validation(Required=false)]
            public long? ContainerQuitTime { get; set; }

            [NameInMap("ContainerStartTime")]
            [Validation(Required=false)]
            public long? ContainerStartTime { get; set; }

            [NameInMap("ContainerState")]
            [Validation(Required=false)]
            public string ContainerState { get; set; }

            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }

            [NameInMap("GameSessionId")]
            [Validation(Required=false)]
            public string GameSessionId { get; set; }

            [NameInMap("PlayerDetailList")]
            [Validation(Required=false)]
            public List<ListContainerStatusResponseBodyDataListPlayerDetailList> PlayerDetailList { get; set; }
            public class ListContainerStatusResponseBodyDataListPlayerDetailList : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("IsInitiator")]
                [Validation(Required=false)]
                public bool? IsInitiator { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
