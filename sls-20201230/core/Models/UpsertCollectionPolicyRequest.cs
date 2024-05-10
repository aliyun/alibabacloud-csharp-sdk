// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpsertCollectionPolicyRequest : TeaModel {
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestAttribute Attribute { get; set; }
        public class UpsertCollectionPolicyRequestAttribute : TeaModel {
            [NameInMap("app")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("policyGroup")]
            [Validation(Required=false)]
            public string PolicyGroup { get; set; }

        }

        [NameInMap("centralizeConfig")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestCentralizeConfig CentralizeConfig { get; set; }
        public class UpsertCollectionPolicyRequestCentralizeConfig : TeaModel {
            [NameInMap("destLogstore")]
            [Validation(Required=false)]
            public string DestLogstore { get; set; }

            [NameInMap("destProject")]
            [Validation(Required=false)]
            public string DestProject { get; set; }

            [NameInMap("destRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            [NameInMap("destTTL")]
            [Validation(Required=false)]
            public int? DestTTL { get; set; }

        }

        [NameInMap("centralizeEnabled")]
        [Validation(Required=false)]
        public bool? CentralizeEnabled { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataCode")]
        [Validation(Required=false)]
        public string DataCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("policyConfig")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestPolicyConfig PolicyConfig { get; set; }
        public class UpsertCollectionPolicyRequestPolicyConfig : TeaModel {
            [NameInMap("instanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            [NameInMap("regions")]
            [Validation(Required=false)]
            public List<string> Regions { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("resourceMode")]
            [Validation(Required=false)]
            public string ResourceMode { get; set; }

            [NameInMap("resourceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceTags { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
