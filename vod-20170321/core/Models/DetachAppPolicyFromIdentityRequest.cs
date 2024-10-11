// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DetachAppPolicyFromIdentityRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. This parameter is optional if you set PolicyNames to VODAppAdministratorAccess. This parameter is required if you set PolicyNames to a value other than VODAppAdministratorAccess.</para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>app-1000000</b>.</description></item>
        /// <item><description>For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</description></item>
        /// </list>
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
        /// <item><description>Specifies the ID of the RAM user for this parameter if you set IdentityType to RamUser.</description></item>
        /// <item><description>Specifies the name of the RAM role for this parameter if you set IdentityType to RamRole.</description></item>
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
        /// <para>The type of the identity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RamUser</b>: RAM user</description></item>
        /// <item><description><b>RamRole</b>: RAM role</description></item>
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
        /// <para>The name of the policy. Separate multiple names with commas (,). Only system policies are supported.</para>
        /// <list type="bullet">
        /// <item><description><b>VODAppFullAccess</b>: permissions to manage all resources in an application</description></item>
        /// <item><description><b>VODAppReadOnlyAccess</b>: permissions to read all resources in an application</description></item>
        /// <item><description><b>VODAppAdministratorAccess</b>: permissions of the application administrator</description></item>
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
