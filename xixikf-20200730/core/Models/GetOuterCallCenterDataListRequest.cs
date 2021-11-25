// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetOuterCallCenterDataListRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("FromPhoneNum")]
        [Validation(Required=false)]
        public string FromPhoneNum { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public string QueryEndTime { get; set; }

        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public string QueryStartTime { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("ToPhoneNum")]
        [Validation(Required=false)]
        public string ToPhoneNum { get; set; }

    }

}
