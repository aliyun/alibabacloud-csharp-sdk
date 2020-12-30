// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClusterADDomainResponseBody : TeaModel {
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("TaskFinished")]
        [Validation(Required=false)]
        public bool? TaskFinished { get; set; }

        [NameInMap("IsSupported")]
        [Validation(Required=false)]
        public bool? IsSupported { get; set; }

        [NameInMap("DomainDnsIp")]
        [Validation(Required=false)]
        public string DomainDnsIp { get; set; }

    }

}
