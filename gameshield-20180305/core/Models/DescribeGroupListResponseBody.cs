// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeGroupListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<DescribeGroupListResponseBodyGroupList> GroupList { get; set; }
        public class DescribeGroupListResponseBodyGroupList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("IsDnsEnabled")]
            [Validation(Required=false)]
            public bool? IsDnsEnabled { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("BlackIp")]
            [Validation(Required=false)]
            public int? BlackIp { get; set; }

            [NameInMap("NormalIp")]
            [Validation(Required=false)]
            public int? NormalIp { get; set; }

            [NameInMap("CleanIp")]
            [Validation(Required=false)]
            public int? CleanIp { get; set; }

            [NameInMap("TotalIp")]
            [Validation(Required=false)]
            public int? TotalIp { get; set; }

            [NameInMap("IsDisabled")]
            [Validation(Required=false)]
            public bool? IsDisabled { get; set; }

            [NameInMap("DnsStatus")]
            [Validation(Required=false)]
            public string DnsStatus { get; set; }

            [NameInMap("GroupDesc")]
            [Validation(Required=false)]
            public string GroupDesc { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
