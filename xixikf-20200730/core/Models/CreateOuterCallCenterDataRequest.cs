// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class CreateOuterCallCenterDataRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CallType")]
        [Validation(Required=false)]
        public string CallType { get; set; }

        [NameInMap("EndReason")]
        [Validation(Required=false)]
        public string EndReason { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("FromPhoneNum")]
        [Validation(Required=false)]
        public string FromPhoneNum { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InterveneTime")]
        [Validation(Required=false)]
        public string InterveneTime { get; set; }

        [NameInMap("RecordUrl")]
        [Validation(Required=false)]
        public string RecordUrl { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ToPhoneNum")]
        [Validation(Required=false)]
        public string ToPhoneNum { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfo { get; set; }

    }

}
