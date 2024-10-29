// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the internal access application. You can obtain the application ID by calling the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: queries all internal access applications.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: creates an internal access application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

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
        /// <para>The name of the internal access tag. The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag_name</para>
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
        /// <para>The ID of the internal access policy. You can obtain the policy ID by calling the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: queries all internal access policies.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: creates an internal access policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-policy-54a7838a48bf****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the simple query mode. A value of true specifies that policy IDs are not queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SimpleMode")]
        [Validation(Required=false)]
        public bool? SimpleMode { get; set; }

        /// <summary>
        /// <para>The IDs of internal access tags. You can specify up to 100 tag IDs.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
