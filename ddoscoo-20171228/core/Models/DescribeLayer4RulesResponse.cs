// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeLayer4RulesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long? Total { get; set; }

        [NameInMap("Listeners")]
        [Validation(Required=true)]
        public List<DescribeLayer4RulesResponseListeners> Listeners { get; set; }
        public class DescribeLayer4RulesResponseListeners : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=true)]
            public string Protocol { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=true)]
            public int? FrontendPort { get; set; }

            [NameInMap("BackendPort")]
            [Validation(Required=true)]
            public int? BackendPort { get; set; }

            [NameInMap("IsAutoCreate")]
            [Validation(Required=true)]
            public bool? IsAutoCreate { get; set; }

            [NameInMap("RealServers")]
            [Validation(Required=true)]
            public List<string> RealServers { get; set; }

        }

    }

}
