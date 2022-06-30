// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeLayer4RulePolicyResponseBody : TeaModel {
        [NameInMap("BackendPort")]
        [Validation(Required=false)]
        public int? BackendPort { get; set; }

        [NameInMap("BakMode")]
        [Validation(Required=false)]
        public string BakMode { get; set; }

        [NameInMap("CurrentIndex")]
        [Validation(Required=false)]
        public int? CurrentIndex { get; set; }

        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PriRealServers")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulePolicyResponseBodyPriRealServers> PriRealServers { get; set; }
        public class DescribeLayer4RulePolicyResponseBodyPriRealServers : TeaModel {
            [NameInMap("CurrentIndex")]
            [Validation(Required=false)]
            public int? CurrentIndex { get; set; }

            [NameInMap("Eip")]
            [Validation(Required=false)]
            public string Eip { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecRealServers")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulePolicyResponseBodySecRealServers> SecRealServers { get; set; }
        public class DescribeLayer4RulePolicyResponseBodySecRealServers : TeaModel {
            [NameInMap("CurrentIndex")]
            [Validation(Required=false)]
            public int? CurrentIndex { get; set; }

            [NameInMap("Eip")]
            [Validation(Required=false)]
            public string Eip { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

        }

    }

}
