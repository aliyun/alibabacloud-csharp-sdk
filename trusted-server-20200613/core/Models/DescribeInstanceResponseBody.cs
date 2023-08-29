// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("GmtRecentReport")]
        [Validation(Required=false)]
        public long? GmtRecentReport { get; set; }

        [NameInMap("OnlineStatus")]
        [Validation(Required=false)]
        public int? OnlineStatus { get; set; }

        [NameInMap("ProgramExceptionNum")]
        [Validation(Required=false)]
        public int? ProgramExceptionNum { get; set; }

        [NameInMap("ProgramTrustDetail")]
        [Validation(Required=false)]
        public string ProgramTrustDetail { get; set; }

        [NameInMap("ProgramTrustStatus")]
        [Validation(Required=false)]
        public int? ProgramTrustStatus { get; set; }

        [NameInMap("ProgramWhiteListId")]
        [Validation(Required=false)]
        public int? ProgramWhiteListId { get; set; }

        [NameInMap("ProgramWhiteListName")]
        [Validation(Required=false)]
        public string ProgramWhiteListName { get; set; }

        [NameInMap("PropertyAffiliation")]
        [Validation(Required=false)]
        public int? PropertyAffiliation { get; set; }

        [NameInMap("PropertyName")]
        [Validation(Required=false)]
        public string PropertyName { get; set; }

        [NameInMap("PropertyPrivateIp")]
        [Validation(Required=false)]
        public string PropertyPrivateIp { get; set; }

        [NameInMap("PropertyPublicIp")]
        [Validation(Required=false)]
        public string PropertyPublicIp { get; set; }

        [NameInMap("PropertyUuid")]
        [Validation(Required=false)]
        public string PropertyUuid { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemExceptionNum")]
        [Validation(Required=false)]
        public int? SystemExceptionNum { get; set; }

        [NameInMap("SystemTrustDetail")]
        [Validation(Required=false)]
        public string SystemTrustDetail { get; set; }

        [NameInMap("SystemTrustStatus")]
        [Validation(Required=false)]
        public int? SystemTrustStatus { get; set; }

        [NameInMap("SystemWhiteListId")]
        [Validation(Required=false)]
        public int? SystemWhiteListId { get; set; }

    }

}
