// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyItems> Items { get; set; }
        public class DescribeEventsResponseBodyItems : TeaModel {
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            [NameInMap("Backed")]
            [Validation(Required=false)]
            public bool? Backed { get; set; }

            [NameInMap("DealDisplayName")]
            [Validation(Required=false)]
            public string DealDisplayName { get; set; }

            [NameInMap("DealLoginName")]
            [Validation(Required=false)]
            public string DealLoginName { get; set; }

            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            [NameInMap("DealUserId")]
            [Validation(Required=false)]
            public long? DealUserId { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            [NameInMap("SubTypeCode")]
            [Validation(Required=false)]
            public string SubTypeCode { get; set; }

            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }

            [NameInMap("TargetProductCode")]
            [Validation(Required=false)]
            public string TargetProductCode { get; set; }

            [NameInMap("TypeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("WarnLevel")]
            [Validation(Required=false)]
            public int? WarnLevel { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
