// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class JobSettings : TeaModel {
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedSettings { get; set; }

        [NameInMap("BusinessUserId")]
        [Validation(Required=false)]
        public string BusinessUserId { get; set; }

        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("Driver")]
        [Validation(Required=false)]
        public string Driver { get; set; }

        [NameInMap("EnableErrorMonitoringInAIMaster")]
        [Validation(Required=false)]
        public bool? EnableErrorMonitoringInAIMaster { get; set; }

        [NameInMap("EnableOssAppend")]
        [Validation(Required=false)]
        public bool? EnableOssAppend { get; set; }

        [NameInMap("EnableRDMA")]
        [Validation(Required=false)]
        public bool? EnableRDMA { get; set; }

        [NameInMap("EnableSanityCheck")]
        [Validation(Required=false)]
        public bool? EnableSanityCheck { get; set; }

        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        [NameInMap("ErrorMonitoringArgs")]
        [Validation(Required=false)]
        public string ErrorMonitoringArgs { get; set; }

        [NameInMap("JobReservedMinutes")]
        [Validation(Required=false)]
        public int? JobReservedMinutes { get; set; }

        [NameInMap("JobReservedPolicy")]
        [Validation(Required=false)]
        public string JobReservedPolicy { get; set; }

        [NameInMap("OversoldType")]
        [Validation(Required=false)]
        public string OversoldType { get; set; }

        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("SanityCheckArgs")]
        [Validation(Required=false)]
        public string SanityCheckArgs { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
