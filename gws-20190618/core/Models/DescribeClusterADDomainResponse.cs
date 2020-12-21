// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClusterADDomainResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("IsSupported")]
        [Validation(Required=true)]
        public bool? IsSupported { get; set; }

        [NameInMap("TaskFinished")]
        [Validation(Required=true)]
        public bool? TaskFinished { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("DomainDnsIp")]
        [Validation(Required=true)]
        public string DomainDnsIp { get; set; }

    }

}
