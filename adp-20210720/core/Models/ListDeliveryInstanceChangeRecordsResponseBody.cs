// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListDeliveryInstanceChangeRecordsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDeliveryInstanceChangeRecordsResponseBodyData> Data { get; set; }
        public class ListDeliveryInstanceChangeRecordsResponseBodyData : TeaModel {
            [NameInMap("deliverableUID")]
            [Validation(Required=false)]
            public string DeliverableUID { get; set; }

            [NameInMap("envChangeRecords")]
            [Validation(Required=false)]
            public Dictionary<string, object> EnvChangeRecords { get; set; }

            [NameInMap("envNodeInfo")]
            [Validation(Required=false)]
            public List<ListDeliveryInstanceChangeRecordsResponseBodyDataEnvNodeInfo> EnvNodeInfo { get; set; }
            public class ListDeliveryInstanceChangeRecordsResponseBodyDataEnvNodeInfo : TeaModel {
                [NameInMap("capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                [NameInMap("cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("label")]
                [Validation(Required=false)]
                public Dictionary<string, object> Label { get; set; }

                [NameInMap("memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("privateIP")]
                [Validation(Required=false)]
                public string PrivateIP { get; set; }

                [NameInMap("taints")]
                [Validation(Required=false)]
                public Dictionary<string, object> Taints { get; set; }

            }

            [NameInMap("envPackageConfig")]
            [Validation(Required=false)]
            public string EnvPackageConfig { get; set; }

            [NameInMap("originDeliverableUID")]
            [Validation(Required=false)]
            public string OriginDeliverableUID { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
