// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListIoTCloudConnectorAccessSessionLogsResponseBody : TeaModel {
        [NameInMap("AccessSessionLogs")]
        [Validation(Required=false)]
        public List<ListIoTCloudConnectorAccessSessionLogsResponseBodyAccessSessionLogs> AccessSessionLogs { get; set; }
        public class ListIoTCloudConnectorAccessSessionLogsResponseBodyAccessSessionLogs : TeaModel {
            [NameInMap("ClientToServiceFlow")]
            [Validation(Required=false)]
            public string ClientToServiceFlow { get; set; }

            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            [NameInMap("DestinationPort")]
            [Validation(Required=false)]
            public string DestinationPort { get; set; }

            [NameInMap("Destinations")]
            [Validation(Required=false)]
            public List<string> Destinations { get; set; }

            [NameInMap("ServiceToClientFlow")]
            [Validation(Required=false)]
            public string ServiceToClientFlow { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
