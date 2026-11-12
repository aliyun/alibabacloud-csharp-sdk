// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class LoginInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ae7106e68eb4402b0dcbd48a9de****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The password associated with the username of the simple application server.</para>
        /// <list type="bullet">
        /// <item><description>Linux server: No password is required.</description></item>
        /// <item><description>Windows server: Enter the configured password. If you have not set a password after purchasing the simple application server, see <a href="https://help.aliyun.com/document_detail/60055.html">Reset the password</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port number for remote logon to the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>Linux server: The default port is 22.</para>
        /// </description></item>
        /// <item><description><para>Windows server: The default port is 3389.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to connect to the server by using a custom port, you must first change the default remote port of the server. For more information, see <a href="https://help.aliyun.com/document_detail/2807402.html">Settings for custom remote connection ports</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3389</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The region ID of the specified Simple Application Server instance. You can call <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> to query the list of supported Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The username for the simple application server.</para>
        /// <list type="bullet">
        /// <item><description>You do not need to enter a username for a Linux server.</description></item>
        /// <item><description>The default username for a Windows server is <c>administrator</c>.</description></item>
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
