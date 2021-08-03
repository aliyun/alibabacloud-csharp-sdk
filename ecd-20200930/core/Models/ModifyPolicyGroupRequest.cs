// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyPolicyGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        [NameInMap("Html5Access")]
        [Validation(Required=false)]
        public string Html5Access { get; set; }

        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        [NameInMap("WatermarkCustomText")]
        [Validation(Required=false)]
        public string WatermarkCustomText { get; set; }

        [NameInMap("WatermarkTransparency")]
        [Validation(Required=false)]
        public string WatermarkTransparency { get; set; }

        [NameInMap("PreemptLogin")]
        [Validation(Required=false)]
        public string PreemptLogin { get; set; }

        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        [NameInMap("PreemptLoginUser")]
        [Validation(Required=false)]
        public List<string> PreemptLoginUser { get; set; }

        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestAuthorizeSecurityPolicyRule : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

        }

        [NameInMap("RevokeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestRevokeSecurityPolicyRule> RevokeSecurityPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestRevokeSecurityPolicyRule : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

        }

        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestAuthorizeAccessPolicyRule : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

        }

        [NameInMap("RevokeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestRevokeAccessPolicyRule> RevokeAccessPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestRevokeAccessPolicyRule : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

        }

    }

}
