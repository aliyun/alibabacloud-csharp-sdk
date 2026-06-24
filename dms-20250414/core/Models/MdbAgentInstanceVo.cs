// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class MdbAgentInstanceVo : TeaModel {
        [NameInMap("AccessUrl")]
        [Validation(Required=false)]
        public string AccessUrl { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("EngineInstanceId")]
        [Validation(Required=false)]
        public string EngineInstanceId { get; set; }

        [NameInMap("EngineRegion")]
        [Validation(Required=false)]
        public string EngineRegion { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("LastActiveTime")]
        [Validation(Required=false)]
        public string LastActiveTime { get; set; }

        [NameInMap("LockTime")]
        [Validation(Required=false)]
        public string LockTime { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("PublicDomain")]
        [Validation(Required=false)]
        public string PublicDomain { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("StatusDesc")]
        [Validation(Required=false)]
        public string StatusDesc { get; set; }

        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

    }

}
