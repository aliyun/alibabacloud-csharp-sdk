// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopsRequest : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        [NameInMap("DesktopNameSuffix")]
        [Validation(Required=false)]
        public bool? DesktopNameSuffix { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestTag> Tag { get; set; }
        public class CreateDesktopsRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UserAssignMode")]
        [Validation(Required=false)]
        public string UserAssignMode { get; set; }

        [NameInMap("UserCommands")]
        [Validation(Required=false)]
        public List<CreateDesktopsRequestUserCommands> UserCommands { get; set; }
        public class CreateDesktopsRequestUserCommands : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ContentEncoding")]
            [Validation(Required=false)]
            public string ContentEncoding { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

        }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("VolumeEncryptionEnabled")]
        [Validation(Required=false)]
        public bool? VolumeEncryptionEnabled { get; set; }

        [NameInMap("VolumeEncryptionKey")]
        [Validation(Required=false)]
        public string VolumeEncryptionKey { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
