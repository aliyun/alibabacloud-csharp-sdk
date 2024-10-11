// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class LicenseInstanceAppDTO : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("BeginOn")]
        [Validation(Required=false)]
        public string BeginOn { get; set; }

        [NameInMap("ContractNo")]
        [Validation(Required=false)]
        public string ContractNo { get; set; }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("ExpiredOn")]
        [Validation(Required=false)]
        public string ExpiredOn { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        [NameInMap("LicenseConfigs")]
        [Validation(Required=false)]
        public List<LicenseInstanceAppDTOLicenseConfigs> LicenseConfigs { get; set; }
        public class LicenseInstanceAppDTOLicenseConfigs : TeaModel {
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            [NameInMap("FeatureIds")]
            [Validation(Required=false)]
            public string FeatureIds { get; set; }

            [NameInMap("SdkId")]
            [Validation(Required=false)]
            public int? SdkId { get; set; }

            [NameInMap("SdkName")]
            [Validation(Required=false)]
            public string SdkName { get; set; }

            [NameInMap("Subscription")]
            [Validation(Required=false)]
            public string Subscription { get; set; }

            [NameInMap("SubscriptionImp")]
            [Validation(Required=false)]
            public string SubscriptionImp { get; set; }

            [NameInMap("SubscriptionPkg")]
            [Validation(Required=false)]
            public string SubscriptionPkg { get; set; }

        }

        [NameInMap("ModificationTime")]
        [Validation(Required=false)]
        public string ModificationTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
