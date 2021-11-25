// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class QueryHotlineSessionRequest : TeaModel {
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        [NameInMap("CallType")]
        [Validation(Required=false)]
        public int? CallType { get; set; }

        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public long? QueryEndTime { get; set; }

        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public long? QueryStartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public string ServicerId { get; set; }

        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public string ServicerName { get; set; }

    }

}
