// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessPolicesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the private access application. The application ID cannot be used together with the private access tag ID for filtering. Sources of the value:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: Queries private access applications by batch.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: Creates a private access application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The name of the private access application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>办公</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The page number of the current page that is returned during paginated queries. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the private access policy. The name must be 1 to 128 characters in length and supports Chinese characters and uppercase and lowercase English letters. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>private_access_policy_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page that is set during paginated queries. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The action of the private access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Block</b>: Block.</description></item>
        /// <item><description><b>Allow</b>: Allow.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// <para>The collection of private access policy IDs. You can specify up to 100 private access policy IDs.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// <para>The status of the private access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the private access tag. The tag ID cannot be used together with the application ID for filtering. Sources of the value:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessTags~~">ListPrivateAccessTags</a>: Queries private access tags by batch.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessTag~~">CreatePrivateAccessTag</a>: Creates a private access tag.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag-c0cb77857a99****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// <para>The name of the tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>云产品</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The ID of the user group. Sources of the value:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserGroups~~">ListUserGroups</a>: Queries user groups by batch.</description></item>
        /// <item><description><a href="~~CreateUserGroup~~">CreateUserGroup</a>: Creates a user group.</description></item>
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
