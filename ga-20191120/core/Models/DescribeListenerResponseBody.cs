// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeListenerResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyPortRanges> PortRanges { get; set; }
        public class DescribeListenerResponseBodyPortRanges : TeaModel {
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyBackendPorts> BackendPorts { get; set; }
        public class DescribeListenerResponseBodyBackendPorts : TeaModel {
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public string FromPort { get; set; }

            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public string ToPort { get; set; }

        }

        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyCertificates> Certificates { get; set; }
        public class DescribeListenerResponseBodyCertificates : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
