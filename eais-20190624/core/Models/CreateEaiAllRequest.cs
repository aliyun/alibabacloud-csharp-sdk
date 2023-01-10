// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class CreateEaiAllRequest : TeaModel {
        [NameInMap("ClientImageId")]
        [Validation(Required=false)]
        public string ClientImageId { get; set; }

        [NameInMap("ClientInstanceName")]
        [Validation(Required=false)]
        public string ClientInstanceName { get; set; }

        [NameInMap("ClientInstanceType")]
        [Validation(Required=false)]
        public string ClientInstanceType { get; set; }

        [NameInMap("ClientInternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? ClientInternetMaxBandwidthIn { get; set; }

        [NameInMap("ClientInternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? ClientInternetMaxBandwidthOut { get; set; }

        [NameInMap("ClientPassword")]
        [Validation(Required=false)]
        public string ClientPassword { get; set; }

        [NameInMap("ClientSecurityGroupId")]
        [Validation(Required=false)]
        public string ClientSecurityGroupId { get; set; }

        [NameInMap("ClientSystemDiskCategory")]
        [Validation(Required=false)]
        public string ClientSystemDiskCategory { get; set; }

        [NameInMap("ClientSystemDiskSize")]
        [Validation(Required=false)]
        public int? ClientSystemDiskSize { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ClientVSwitchId")]
        [Validation(Required=false)]
        public string ClientVSwitchId { get; set; }

        [NameInMap("ClientZoneId")]
        [Validation(Required=false)]
        public string ClientZoneId { get; set; }

        [NameInMap("EaiInstanceType")]
        [Validation(Required=false)]
        public string EaiInstanceType { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
