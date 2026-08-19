// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAppPoliciesForIdentityRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multiple applications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The identity name.</para>
        /// <list type="bullet">
        /// <item><description>If IdentityType is set to RamUser, specify the Resource Access Management (RAM) user ID.</description></item>
        /// <item><description>If IdentityType is set to RamRole, specify the role name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test****name</para>
        /// </summary>
        [NameInMap("IdentityName")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        /// <summary>
        /// <para>The identity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RamUser</b>: Resource Access Management (RAM) user.</description></item>
        /// <item><description><b>RamRole</b>: RAM role.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RamUser</para>
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

    }

}
