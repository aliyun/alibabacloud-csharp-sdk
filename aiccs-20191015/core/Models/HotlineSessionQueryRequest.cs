// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryRequest : TeaModel {
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        [NameInMap("AcidList")]
        [Validation(Required=false)]
        public List<string> AcidList { get; set; }

        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        [NameInMap("CallResultList")]
        [Validation(Required=false)]
        public List<string> CallResultList { get; set; }

        [NameInMap("CallType")]
        [Validation(Required=false)]
        public int? CallType { get; set; }

        [NameInMap("CallTypeList")]
        [Validation(Required=false)]
        public List<int?> CallTypeList { get; set; }

        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CalledNumberList")]
        [Validation(Required=false)]
        public List<string> CalledNumberList { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        [NameInMap("CallingNumberList")]
        [Validation(Required=false)]
        public List<string> CallingNumberList { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public List<long?> GroupIdList { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("MemberIdList")]
        [Validation(Required=false)]
        public List<string> MemberIdList { get; set; }

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

        [NameInMap("ServicerIdList")]
        [Validation(Required=false)]
        public List<string> ServicerIdList { get; set; }

        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public string ServicerName { get; set; }

    }

}
