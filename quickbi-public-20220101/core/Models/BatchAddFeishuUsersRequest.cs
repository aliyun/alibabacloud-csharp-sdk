// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class BatchAddFeishuUsersRequest : TeaModel {
        /// <summary>
        /// <para>The information about the users to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ad<b><b>fd&quot;: &quot;test&quot;, &quot;82</b></b>5a&quot;: &quot;t\&quot;t&quot;}&quot;</para>
        /// </summary>
        [NameInMap("FeishuUsers")]
        [Validation(Required=false)]
        public string FeishuUsers { get; set; }

        /// <summary>
        /// <para>Specifies whether the user is an admin user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <para>Specifies whether the user is a permission management administrator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAuthAdmin")]
        [Validation(Required=false)]
        public bool? IsAuthAdmin { get; set; }

        /// <summary>
        /// <para>The user groups to which the users belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0d5fb19b-5555-41f0-99da-1248fc27ca51,0f868dd6_68dd_4d13_8422_c5dca3bd4b61&quot;</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        /// <summary>
        /// <para>The user type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: developer</description></item>
        /// <item><description>2: visitor</description></item>
        /// <item><description>3: analyst</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
