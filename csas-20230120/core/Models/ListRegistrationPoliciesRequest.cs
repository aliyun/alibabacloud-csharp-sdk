// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRegistrationPoliciesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>LimitAll</para>
        /// </summary>
        [NameInMap("CompanyLimitType")]
        [Validation(Required=false)]
        public string CompanyLimitType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LimitDiff</para>
        /// </summary>
        [NameInMap("PersonalLimitType")]
        [Validation(Required=false)]
        public string PersonalLimitType { get; set; }

        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>usergroup-6f1ef2fc56b6****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
