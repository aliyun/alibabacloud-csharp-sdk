// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeParentPlatformResponseBody : TeaModel {
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        [NameInMap("ClientAuth")]
        [Validation(Required=false)]
        public bool? ClientAuth { get; set; }

        [NameInMap("ClientGbId")]
        [Validation(Required=false)]
        public string ClientGbId { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("ClientPassword")]
        [Validation(Required=false)]
        public string ClientPassword { get; set; }

        [NameInMap("ClientPort")]
        [Validation(Required=false)]
        public long? ClientPort { get; set; }

        [NameInMap("ClientUsername")]
        [Validation(Required=false)]
        public string ClientUsername { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
