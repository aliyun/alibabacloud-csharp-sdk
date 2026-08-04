// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The value of a user group property. The value must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("AttributeValue")]
        [Validation(Required=false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the user group. The name must be 1 to 128 characters in length. It can contain letters, digits, periods (.), underscores (_), and hyphens (-). It supports both uppercase and lowercase letters and Chinese characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_group_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of an internal network access policy. You can get this value from:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: List internal network access policies.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: Create an internal network access policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-policy-54a7838a48bf****</para>
        /// </summary>
        [NameInMap("PAPolicyId")]
        [Validation(Required=false)]
        public string PAPolicyId { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A collection of user group IDs. You can specify up to 100 IDs.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
