// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsPackageSummaryNewResponseBody : TeaModel {
        [NameInMap("CertifyType")]
        [Validation(Required=false)]
        public int? CertifyType { get; set; }

        [NameInMap("InterPackageCount")]
        [Validation(Required=false)]
        public long? InterPackageCount { get; set; }

        [NameInMap("InterPackageSum")]
        [Validation(Required=false)]
        public long? InterPackageSum { get; set; }

        [NameInMap("MktPackageCount")]
        [Validation(Required=false)]
        public long? MktPackageCount { get; set; }

        [NameInMap("MktPackageSum")]
        [Validation(Required=false)]
        public long? MktPackageSum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmsPackageCount")]
        [Validation(Required=false)]
        public long? SmsPackageCount { get; set; }

        [NameInMap("SmsPackageSum")]
        [Validation(Required=false)]
        public long? SmsPackageSum { get; set; }

        [NameInMap("SysPackageCount")]
        [Validation(Required=false)]
        public long? SysPackageCount { get; set; }

        [NameInMap("SysPackageSum")]
        [Validation(Required=false)]
        public long? SysPackageSum { get; set; }

    }

}
