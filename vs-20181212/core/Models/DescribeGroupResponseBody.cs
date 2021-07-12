// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeGroupResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("LazyPull")]
        [Validation(Required=false)]
        public bool? LazyPull { get; set; }

        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("InProtocol")]
        [Validation(Required=false)]
        public string InProtocol { get; set; }

        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PushDomain")]
        [Validation(Required=false)]
        public string PushDomain { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("CaptureVideo")]
        [Validation(Required=false)]
        public int? CaptureVideo { get; set; }

        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        [NameInMap("CaptureInterval")]
        [Validation(Required=false)]
        public int? CaptureInterval { get; set; }

        [NameInMap("GbPort")]
        [Validation(Required=false)]
        public long? GbPort { get; set; }

        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        [NameInMap("GbIp")]
        [Validation(Required=false)]
        public string GbIp { get; set; }

        [NameInMap("CaptureImage")]
        [Validation(Required=false)]
        public int? CaptureImage { get; set; }

        [NameInMap("AliasId")]
        [Validation(Required=false)]
        public string AliasId { get; set; }

        [NameInMap("CaptureOssBucket")]
        [Validation(Required=false)]
        public string CaptureOssBucket { get; set; }

        [NameInMap("CaptureOssPath")]
        [Validation(Required=false)]
        public string CaptureOssPath { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("GbTcpPorts")]
        [Validation(Required=false)]
        public List<string> GbTcpPorts { get; set; }

        [NameInMap("GbUdpPorts")]
        [Validation(Required=false)]
        public List<string> GbUdpPorts { get; set; }

        [NameInMap("Stats")]
        [Validation(Required=false)]
        public DescribeGroupResponseBodyStats Stats { get; set; }
        public class DescribeGroupResponseBodyStats : TeaModel {
            [NameInMap("PlatformNum")]
            [Validation(Required=false)]
            public long? PlatformNum { get; set; }
            [NameInMap("DeviceNum")]
            [Validation(Required=false)]
            public long? DeviceNum { get; set; }
            [NameInMap("IpcNum")]
            [Validation(Required=false)]
            public long? IpcNum { get; set; }
            [NameInMap("IedNum")]
            [Validation(Required=false)]
            public long? IedNum { get; set; }
        };

    }

}
