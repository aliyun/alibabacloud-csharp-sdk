// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AttachAppPolicyToIdentityRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application service</a>.</para>
        /// <remarks>
        /// <para>This parameter is optional only if you set the policy name to VODAppAdministratorAccess.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user or the name of the RAM role.</para>
        /// <list type="bullet">
        /// <item><description>Specify the ID of the RAM user when the IdentityType parameter is set to RamUser.</description></item>
        /// <item><description>Specify the name of the RAM role when the IdentityType parameter is set to RamRole.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("IdentityName")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        /// <summary>
        /// <para>The type of the identity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RamUser</b>: a RAM user</description></item>
        /// <item><description><b>RamRole</b>: a RAM role</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RamRole</para>
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>The name of the policy. Only system policies are supported. Separate multiple policy names with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VODAppFullAccess</b>: permissions to manage all resources in an application.</description></item>
        /// <item><description><b>VODAppReadOnlyAccess</b>: permissions to read all resources in an application.</description></item>
        /// <item><description><b>VODAppAdministratorAccess</b>: permissions of the application administrator.</description></item>
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
