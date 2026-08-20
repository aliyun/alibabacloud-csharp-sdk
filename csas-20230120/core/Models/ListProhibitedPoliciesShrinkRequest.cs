// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListProhibitedPoliciesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the policy is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. The policy is delivered to endpoints and takes effect.</description></item>
        /// <item><description><b>false</b>: Disabled. The policy configuration is retained but not delivered to endpoints.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: Applies to all users under the current Alibaba Cloud account. No user group needs to be specified.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Applies only to users in the user groups specified by UserGroupIds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>Policy Name of the software prohibition policy. Fuzzy match is supported. Policy Name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The object type of the controlled target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>App</b>: Controls by prohibited software. The controlled objects are specified by SoftwareIds.</description></item>
        /// <item><description><b>Tag</b>: Controls by prohibited software tag. The controlled objects are specified by TagIds. All prohibited software under the tag is controlled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>App</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The collection of software prohibition policy IDs. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// <para>The action to take. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ban</b>: Blocks the software from running and displays a pop-up notification on the endpoint to alert the user.</description></item>
        /// <item><description><b>BanSilent</b>: Blocks the software from running without notifying the user. The blocking is silent.</description></item>
        /// <item><description><b>Warn</b>: Only displays a pop-up notification on the endpoint to alert the user without blocking the software from running.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ban</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the prohibited software.</para>
        /// </summary>
        [NameInMap("SoftwareId")]
        [Validation(Required=false)]
        public string SoftwareIdShrink { get; set; }

        /// <summary>
        /// <para>The name of the prohibited software. Fuzzy match is supported. The name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thunder</para>
        /// </summary>
        [NameInMap("SoftwareName")]
        [Validation(Required=false)]
        public string SoftwareName { get; set; }

        /// <summary>
        /// <para>The prohibited software tag ID, used to filter policies that reference this tag. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListProhibitedTags~~">ListProhibitedTags</a>: Lists prohibited software tags.</description></item>
        /// <item><description><a href="~~CreateProhibitedTag~~">CreateProhibitedTag</a>: Creates a custom prohibited software tag.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// <para>The name of the prohibited software tag. Fuzzy match is supported. The name can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudProduct</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The user group ID, used to filter policies whose effective scope includes this user group. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserGroups~~">ListUserGroups</a>: Lists user groups.</description></item>
        /// <item><description><a href="~~CreateUserGroup~~">CreateUserGroup</a>: Creates a user group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>usergroup-9d4f2a7b3c1e****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
