// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserLatestPlanResponseBody : TeaModel {
        [NameInMap("accountHandleStatus")]
        [Validation(Required=false)]
        public int? AccountHandleStatus { get; set; }

        [NameInMap("accountHandleTime")]
        [Validation(Required=false)]
        public string AccountHandleTime { get; set; }

        [NameInMap("accountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        [NameInMap("agreementFirstSignTime")]
        [Validation(Required=false)]
        public string AgreementFirstSignTime { get; set; }

        [NameInMap("agreementLastSignTime")]
        [Validation(Required=false)]
        public string AgreementLastSignTime { get; set; }

        [NameInMap("agreementStatus")]
        [Validation(Required=false)]
        public int? AgreementStatus { get; set; }

        [NameInMap("dataHandleEndTime")]
        [Validation(Required=false)]
        public string DataHandleEndTime { get; set; }

        [NameInMap("dataHandleStartTime")]
        [Validation(Required=false)]
        public string DataHandleStartTime { get; set; }

        [NameInMap("dataHandleStatus")]
        [Validation(Required=false)]
        public int? DataHandleStatus { get; set; }

        [NameInMap("exclusivePlan")]
        [Validation(Required=false)]
        public int? ExclusivePlan { get; set; }

        [NameInMap("newAccountUid")]
        [Validation(Required=false)]
        public long? NewAccountUid { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
