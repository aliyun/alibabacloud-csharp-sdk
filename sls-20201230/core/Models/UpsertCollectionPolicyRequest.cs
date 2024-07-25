// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpsertCollectionPolicyRequest : TeaModel {
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

        [NameInMap("dataConfig")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestDataConfig DataConfig { get; set; }
        public class UpsertCollectionPolicyRequestDataConfig : TeaModel {
            [NameInMap("dataRegion")]
            [Validation(Required=false)]
            public string DataRegion { get; set; }

        }

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

        [NameInMap("resourceDirectory")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestResourceDirectory ResourceDirectory { get; set; }
        public class UpsertCollectionPolicyRequestResourceDirectory : TeaModel {
            [NameInMap("accountGroupType")]
            [Validation(Required=false)]
            public string AccountGroupType { get; set; }

            [NameInMap("members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }

        }

    }

}
