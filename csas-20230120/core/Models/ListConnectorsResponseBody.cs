// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListConnectorsResponseBody : TeaModel {
        [NameInMap("Connectors")]
        [Validation(Required=false)]
        public List<ListConnectorsResponseBodyConnectors> Connectors { get; set; }
        public class ListConnectorsResponseBodyConnectors : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListConnectorsResponseBodyConnectorsApplications> Applications { get; set; }
            public class ListConnectorsResponseBodyConnectorsApplications : TeaModel {
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

            }

            /// <summary>
            /// ConnectorID。
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            [NameInMap("UpgradeTime")]
            [Validation(Required=false)]
            public ListConnectorsResponseBodyConnectorsUpgradeTime UpgradeTime { get; set; }
            public class ListConnectorsResponseBodyConnectorsUpgradeTime : TeaModel {
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
