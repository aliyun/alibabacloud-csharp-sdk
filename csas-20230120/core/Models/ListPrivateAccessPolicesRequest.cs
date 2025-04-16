// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessPolicesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the office application. Either the ID or tag of the office application is used for queries. You can obtain the value by calling the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: queries office applications.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: creates an office application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The name of the office application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the private access policy. The value must be 1 to 128 characters in length and can contain letters, digits, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>private_access_policy_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The action in the private access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Block</b></description></item>
        /// <item><description><b>Allow</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// <para>The IDs of the private access policies. You can enter up to 100 IDs.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// <para>The status of the private access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the tag for the office application. Either the ID or tag of the office application is used for queries. You can obtain the value by calling the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessTags~~">ListPrivateAccessTags</a>: queries tags for office applications.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessTag~~">CreatePrivateAccessTag</a>: creates a tag for office applications.</description></item>
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
        /// <para>Cloud service</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The ID of the user group. You can obtain the value by calling the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserGroups~~">ListUserGroups</a>: queries user groups.</description></item>
        /// <item><description><a href="~~CreateUserGroup~~">CreateUserGroup</a>: creates a user group.</description></item>
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
