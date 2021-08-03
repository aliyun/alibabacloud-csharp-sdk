// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePolicyGroupsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribePolicyGroupsResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseBodyDescribePolicyGroups : TeaModel {
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            [NameInMap("Html5Access")]
            [Validation(Required=false)]
            public string Html5Access { get; set; }

            [NameInMap("WatermarkType")]
            [Validation(Required=false)]
            public string WatermarkType { get; set; }

            [NameInMap("PreemptLogin")]
            [Validation(Required=false)]
            public string PreemptLogin { get; set; }

            [NameInMap("WatermarkCustomText")]
            [Validation(Required=false)]
            public string WatermarkCustomText { get; set; }

            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public string DomainList { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("WatermarkTransparency")]
            [Validation(Required=false)]
            public string WatermarkTransparency { get; set; }

            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            [NameInMap("VisualQuality")]
            [Validation(Required=false)]
            public string VisualQuality { get; set; }

            [NameInMap("EdsCount")]
            [Validation(Required=false)]
            public int? EdsCount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            [NameInMap("AuthorizeSecurityPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules> AuthorizeSecurityPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

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

            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

            }

            [NameInMap("PreemptLoginUsers")]
            [Validation(Required=false)]
            public List<string> PreemptLoginUsers { get; set; }

        }

    }

}
