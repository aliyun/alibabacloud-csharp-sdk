// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class LoginInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ae7106e68eb4402b0dcbd48a9de****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The password that corresponds to the username.</para>
        /// <list type="bullet">
        /// <item><description>For a Linux server, you do not need to enter a password.</description></item>
        /// <item><description>For a Windows server, enter the password that you set. If you have not set a password for the simple application server, set a password. For more information, see <a href="https://help.aliyun.com/document_detail/60055.html">Reset the password</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Remote login instance port number:</para>
        /// <list type="bullet">
        /// <item><description>Linux Server: Default is 22.</description></item>
        /// <item><description>Windows Server: Default is 3389.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you need to connect to the server using a custom port, you must first modify the server\&quot;s default remote port. For more information, see <a href="https://help.aliyun.com/document_detail/2807402.html">Set a custom port to connect to a simple application server</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3389</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application server. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The username of the simple application server.</para>
        /// <list type="bullet">
        /// <item><description>For a Linux server, you do not need to enter a username.</description></item>
        /// <item><description>For a Windows server, the default username <c>administrator</c> is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>administrator</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
