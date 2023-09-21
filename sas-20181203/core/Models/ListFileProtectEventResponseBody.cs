// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectEventResponseBody : TeaModel {
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<ListFileProtectEventResponseBodyEventList> EventList { get; set; }
        public class ListFileProtectEventResponseBodyEventList : TeaModel {
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public int? AlertLevel { get; set; }

            [NameInMap("CmdLine")]
            [Validation(Required=false)]
            public string CmdLine { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("HandleTime")]
            [Validation(Required=false)]
            public long? HandleTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("ProcPath")]
            [Validation(Required=false)]
            public string ProcPath { get; set; }

            [NameInMap("ProcPermission")]
            [Validation(Required=false)]
            public string ProcPermission { get; set; }

            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectEventResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
