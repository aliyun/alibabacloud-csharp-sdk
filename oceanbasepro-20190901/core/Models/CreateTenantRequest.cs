// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantRequest : TeaModel {
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public string Charset { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        [NameInMap("TenantMode")]
        [Validation(Required=false)]
        public string TenantMode { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("UnitNum")]
        [Validation(Required=false)]
        public int? UnitNum { get; set; }

        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

        [NameInMap("UserVpcId")]
        [Validation(Required=false)]
        public string UserVpcId { get; set; }

    }

}
