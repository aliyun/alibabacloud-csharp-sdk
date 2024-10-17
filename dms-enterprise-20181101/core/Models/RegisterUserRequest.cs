// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RegisterUserRequest : TeaModel {
        /// <summary>
        /// <para>The mobile number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130000000xx</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The role that you want to assign to the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>USER</b>: a regular user role</description></item>
        /// <item><description><b>DBA</b>: a database administrator (DBA) role</description></item>
        /// <item><description><b>ADMIN</b>: a DMS administrator role</description></item>
        /// <item><description><b>SECURITY_ADMIN</b>: a security administrator role</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the regular user role is assigned to the user by default. You can assign one or more roles to the user. Separate multiple roles with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>USER,DBA</para>
        /// </summary>
        [NameInMap("RoleNames")]
        [Validation(Required=false)]
        public string RoleNames { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To query ID of the tenant, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the &quot;View information about the current tenant&quot; section of the <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a> topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account of the user that you want to register.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        /// <summary>
        /// <para>The nickname of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dmstest</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
