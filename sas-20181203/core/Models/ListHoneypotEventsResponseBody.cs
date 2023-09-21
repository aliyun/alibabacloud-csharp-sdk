// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventsResponseBody : TeaModel {
        [NameInMap("HoneypotEvents")]
        [Validation(Required=false)]
        public List<ListHoneypotEventsResponseBodyHoneypotEvents> HoneypotEvents { get; set; }
        public class ListHoneypotEventsResponseBodyHoneypotEvents : TeaModel {
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("AlarmEventId")]
            [Validation(Required=false)]
            public long? AlarmEventId { get; set; }

            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("MergeFieldList")]
            [Validation(Required=false)]
            public List<ListHoneypotEventsResponseBodyHoneypotEventsMergeFieldList> MergeFieldList { get; set; }
            public class ListHoneypotEventsResponseBodyHoneypotEventsMergeFieldList : TeaModel {
                [NameInMap("FieldExtInfo")]
                [Validation(Required=false)]
                public string FieldExtInfo { get; set; }

                [NameInMap("FieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                [NameInMap("FieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotEventsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotEventsResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

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
