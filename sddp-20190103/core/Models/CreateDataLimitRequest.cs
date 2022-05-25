// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateDataLimitRequest : TeaModel {
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        [NameInMap("AutoScan")]
        [Validation(Required=false)]
        public int? AutoScan { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public int? EventStatus { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LogStoreDay")]
        [Validation(Required=false)]
        public int? LogStoreDay { get; set; }

        [NameInMap("OcrStatus")]
        [Validation(Required=false)]
        public int? OcrStatus { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        [NameInMap("SamplingSize")]
        [Validation(Required=false)]
        public int? SamplingSize { get; set; }

        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
