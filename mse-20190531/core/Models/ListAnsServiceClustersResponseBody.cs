// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsServiceClustersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnsServiceClustersResponseBodyData Data { get; set; }
        public class ListAnsServiceClustersResponseBodyData : TeaModel {
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<ListAnsServiceClustersResponseBodyDataClusters> Clusters { get; set; }
            public class ListAnsServiceClustersResponseBodyDataClusters : TeaModel {
                [NameInMap("DefaultCheckPort")]
                [Validation(Required=false)]
                public int? DefaultCheckPort { get; set; }

                [NameInMap("DefaultPort")]
                [Validation(Required=false)]
                public int? DefaultPort { get; set; }

                [NameInMap("HealthCheckerType")]
                [Validation(Required=false)]
                public string HealthCheckerType { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("UseIPPort4Check")]
                [Validation(Required=false)]
                public bool? UseIPPort4Check { get; set; }

            }

            [NameInMap("Ephemeral")]
            [Validation(Required=false)]
            public bool? Ephemeral { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProtectThreshold")]
            [Validation(Required=false)]
            public float? ProtectThreshold { get; set; }

            [NameInMap("SelectorType")]
            [Validation(Required=false)]
            public string SelectorType { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
