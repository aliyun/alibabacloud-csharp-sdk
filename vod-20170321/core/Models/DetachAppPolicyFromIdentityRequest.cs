// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DetachAppPolicyFromIdentityRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. If the policy name is VODAppAdministratorAccess, this parameter is optional. For other policies, this parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>Value (default): <b>app-1000000</b>.</description></item>
        /// <item><description>For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</description></item>
        /// </list>
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
        /// <item><description>If the type is RamUser, specify the Resource Access Management (RAM) user ID.</description></item>
        /// <item><description>If the type is RamRole, specify the role name.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RamUser</para>
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>The policy names. Separate multiple names with commas (,). Only system policies are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VODAppFullAccess</b>: permissions to manage and operate all resources in the application.</description></item>
        /// <item><description><b>VODAppReadOnlyAccess</b>: read-only permissions for all resources in the application.</description></item>
        /// <item><description><b>VODAppAdministratorAccess</b>: application administrator permissions.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VODAppFullAccess</para>
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

    }

}
