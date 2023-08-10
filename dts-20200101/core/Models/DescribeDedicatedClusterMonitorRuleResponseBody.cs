// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDedicatedClusterMonitorRuleResponseBody : TeaModel {
        [NameInMap("CpuAlarmThreshold")]
        [Validation(Required=false)]
        public string CpuAlarmThreshold { get; set; }

        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        [NameInMap("DiskAlarmThreshold")]
        [Validation(Required=false)]
        public string DiskAlarmThreshold { get; set; }

        [NameInMap("DuAlarmThreshold")]
        [Validation(Required=false)]
        public string DuAlarmThreshold { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("MemAlarmThreshold")]
        [Validation(Required=false)]
        public string MemAlarmThreshold { get; set; }

        [NameInMap("NoticeSwitch")]
        [Validation(Required=false)]
        public string NoticeSwitch { get; set; }

        [NameInMap("Phones")]
        [Validation(Required=false)]
        public string Phones { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
