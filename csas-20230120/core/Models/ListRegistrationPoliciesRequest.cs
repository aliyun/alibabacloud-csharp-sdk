// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRegistrationPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The type of company device registration limit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Unlimited</b>: No limit.</para>
        /// </description></item>
        /// <item><description><para><b>LimitAll</b>: Limit by total number.</para>
        /// </description></item>
        /// <item><description><para><b>LimitDiff</b>: Limit by device categorization.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LimitAll</para>
        /// </summary>
        [NameInMap("CompanyLimitType")]
        [Validation(Required=false)]
        public string CompanyLimitType { get; set; }

        /// <summary>
        /// <para>The current page number for paged queries. Values range from 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The policy matching target type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UserGroupAll</b>: Associate all users.</para>
        /// </description></item>
        /// <item><description><para><b>UserGroupNormal</b>: Associate some user groups.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The name of the device registration policy. It can be 1 to 128 characters long. It supports Chinese characters, uppercase and lowercase English letters, numbers, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>registration_policy_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of items per page for paged queries. Values range from 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The type of personal device registration limit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Unlimited</b>: No limit.</para>
        /// </description></item>
        /// <item><description><para><b>LimitAll</b>: Limit by total number.</para>
        /// </description></item>
        /// <item><description><para><b>LimitDiff</b>: Limit by device categorization.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LimitDiff</para>
        /// </summary>
        [NameInMap("PersonalLimitType")]
        [Validation(Required=false)]
        public string PersonalLimitType { get; set; }

        /// <summary>
        /// <para>A collection of device registration policy IDs. You can enter up to 100 device registration policy IDs.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// <para>The status of the device registration policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The user group ID. Get this value from:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListUserGroups~~">ListUserGroups</a>: Batch query user groups.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreateUserGroup~~">CreateUserGroup</a>: Create user groups.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>usergroup-6f1ef2fc56b6****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
