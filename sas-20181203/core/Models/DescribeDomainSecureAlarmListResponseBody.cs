// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainSecureAlarmListResponseBody : TeaModel {
        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public List<DescribeDomainSecureAlarmListResponseBodyAlarmList> AlarmList { get; set; }
        public class DescribeDomainSecureAlarmListResponseBodyAlarmList : TeaModel {
            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            [NameInMap("AlarmEventNameOriginal")]
            [Validation(Required=false)]
            public string AlarmEventNameOriginal { get; set; }

            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            [NameInMap("AutoBreaking")]
            [Validation(Required=false)]
            public bool? AutoBreaking { get; set; }

            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            [NameInMap("Dealed")]
            [Validation(Required=false)]
            public bool? Dealed { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("HasTraceInfo")]
            [Validation(Required=false)]
            public bool? HasTraceInfo { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("OperateErrorCode")]
            [Validation(Required=false)]
            public string OperateErrorCode { get; set; }

            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public string SaleVersion { get; set; }

            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public string SecurityEventIds { get; set; }

            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            [NameInMap("Stages")]
            [Validation(Required=false)]
            public string Stages { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("SuspiciousEventCount")]
            [Validation(Required=false)]
            public int? SuspiciousEventCount { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
