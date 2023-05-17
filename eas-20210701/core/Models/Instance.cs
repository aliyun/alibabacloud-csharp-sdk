// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Instance : TeaModel {
        [NameInMap("CurrentAmount")]
        [Validation(Required=false)]
        public float? CurrentAmount { get; set; }

        [NameInMap("HostIP")]
        [Validation(Required=false)]
        public string HostIP { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("InnerIP")]
        [Validation(Required=false)]
        public string InnerIP { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        [NameInMap("IsSpot")]
        [Validation(Required=false)]
        public bool? IsSpot { get; set; }

        [NameInMap("LastState")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> LastState { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OriginalAmount")]
        [Validation(Required=false)]
        public float? OriginalAmount { get; set; }

        [NameInMap("ReadyProcesses")]
        [Validation(Required=false)]
        public int? ReadyProcesses { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("StartAt")]
        [Validation(Required=false)]
        public string StartAt { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TenantHostIP")]
        [Validation(Required=false)]
        public string TenantHostIP { get; set; }

        [NameInMap("TenantInstanceIP")]
        [Validation(Required=false)]
        public string TenantInstanceIP { get; set; }

        [NameInMap("TotalProcesses")]
        [Validation(Required=false)]
        public int? TotalProcesses { get; set; }

    }

}
