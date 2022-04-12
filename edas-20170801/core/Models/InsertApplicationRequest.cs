// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertApplicationRequest : TeaModel {
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public int? BuildPackId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EcuInfo")]
        [Validation(Required=false)]
        public string EcuInfo { get; set; }

        [NameInMap("EnablePortCheck")]
        [Validation(Required=false)]
        public bool? EnablePortCheck { get; set; }

        [NameInMap("EnableUrlCheck")]
        [Validation(Required=false)]
        public bool? EnableUrlCheck { get; set; }

        [NameInMap("HealthCheckURL")]
        [Validation(Required=false)]
        public string HealthCheckURL { get; set; }

        [NameInMap("HealthCheckUrl")]
        [Validation(Required=false)]
        public string HealthCheckUrl { get; set; }

        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string Hooks { get; set; }

        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        [NameInMap("JvmOptions")]
        [Validation(Required=false)]
        public string JvmOptions { get; set; }

        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        [NameInMap("MaxHeapSize")]
        [Validation(Required=false)]
        public int? MaxHeapSize { get; set; }

        [NameInMap("MaxPermSize")]
        [Validation(Required=false)]
        public int? MaxPermSize { get; set; }

        [NameInMap("Mem")]
        [Validation(Required=false)]
        public int? Mem { get; set; }

        [NameInMap("MinHeapSize")]
        [Validation(Required=false)]
        public int? MinHeapSize { get; set; }

        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        [NameInMap("ReservedPortStr")]
        [Validation(Required=false)]
        public string ReservedPortStr { get; set; }

        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
