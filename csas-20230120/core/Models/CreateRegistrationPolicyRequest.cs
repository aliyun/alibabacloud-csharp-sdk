// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateRegistrationPolicyRequest : TeaModel {
        [NameInMap("CompanyLimitCount")]
        [Validation(Required=false)]
        public CreateRegistrationPolicyRequestCompanyLimitCount CompanyLimitCount { get; set; }
        public class CreateRegistrationPolicyRequestCompanyLimitCount : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public int? All { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public int? Mobile { get; set; }

            [NameInMap("PC")]
            [Validation(Required=false)]
            public int? PC { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompanyLimitType")]
        [Validation(Required=false)]
        public string CompanyLimitType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PersonalLimitCount")]
        [Validation(Required=false)]
        public CreateRegistrationPolicyRequestPersonalLimitCount PersonalLimitCount { get; set; }
        public class CreateRegistrationPolicyRequestPersonalLimitCount : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public int? All { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public int? Mobile { get; set; }

            [NameInMap("PC")]
            [Validation(Required=false)]
            public int? PC { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PersonalLimitType")]
        [Validation(Required=false)]
        public string PersonalLimitType { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
