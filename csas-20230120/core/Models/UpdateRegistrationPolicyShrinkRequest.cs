// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateRegistrationPolicyShrinkRequest : TeaModel {
        [NameInMap("CompanyLimitCount")]
        [Validation(Required=false)]
        public string CompanyLimitCountShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LimitAll</para>
        /// </summary>
        [NameInMap("CompanyLimitType")]
        [Validation(Required=false)]
        public string CompanyLimitType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UserGroupNormal</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registration_policy_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PersonalLimitCount")]
        [Validation(Required=false)]
        public string PersonalLimitCountShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LimitDiff</para>
        /// </summary>
        [NameInMap("PersonalLimitType")]
        [Validation(Required=false)]
        public string PersonalLimitType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reg-policy-63b2f1844b86****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
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
