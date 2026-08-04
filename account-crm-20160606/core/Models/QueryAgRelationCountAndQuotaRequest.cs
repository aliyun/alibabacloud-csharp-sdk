// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAgRelationCountAndQuotaRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("CallerBid")]
        [Validation(Required=false)]
        public long? CallerBid { get; set; }

        [NameInMap("CallerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

        [NameInMap("Mpk")]
        [Validation(Required=false)]
        public string Mpk { get; set; }

        [NameInMap("NullObject")]
        [Validation(Required=false)]
        public bool? NullObject { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("StsTokenCallerBid")]
        [Validation(Required=false)]
        public long? StsTokenCallerBid { get; set; }

        [NameInMap("StsTokenCallerUid")]
        [Validation(Required=false)]
        public long? StsTokenCallerUid { get; set; }

        [NameInMap("StsTokenRoleId")]
        [Validation(Required=false)]
        public long? StsTokenRoleId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
