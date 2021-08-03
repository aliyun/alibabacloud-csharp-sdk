// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("DefaultInitDesktopCount")]
        [Validation(Required=false)]
        public int? DefaultInitDesktopCount { get; set; }

        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public int? OwnType { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

    }

}
