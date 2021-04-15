// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsServiceClustersResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnsServiceClustersResponseBodyData Data { get; set; }
        public class ListAnsServiceClustersResponseBodyData : TeaModel {
            [NameInMap("ProtectThreshold")]
            [Validation(Required=false)]
            public float? ProtectThreshold { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<ListAnsServiceClustersResponseBodyDataClusters> Clusters { get; set; }
            public class ListAnsServiceClustersResponseBodyDataClusters : TeaModel {
                public int? DefaultCheckPort { get; set; }
                public string HealthCheckerType { get; set; }
                public bool? UseIPPort4Check { get; set; }
                public string ServiceName { get; set; }
                public string Name { get; set; }
                public int? DefaultPort { get; set; }
                public Dictionary<string, string> Metadata { get; set; }
            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("SelectorType")]
            [Validation(Required=false)]
            public string SelectorType { get; set; }
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
