// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyInstanceLDAPAuthServerRequest : TeaModel {
        /// <summary>
        /// <para>The username of the account that is used for the LDAP server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn=Manager,dc=test,dc=com</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The Base distinguished name (DN).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc=test,dc=com</para>
        /// </summary>
        [NameInMap("BaseDN")]
        [Validation(Required=false)]
        public string BaseDN { get; set; }

        /// <summary>
        /// <para>The field that is used to indicate the email address of a user on the LDAP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emailAttr</para>
        /// </summary>
        [NameInMap("EmailMapping")]
        [Validation(Required=false)]
        public string EmailMapping { get; set; }

        /// <summary>
        /// <para>The condition that is used to filter users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(objectClass=top)</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to support SSL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSSL")]
        [Validation(Required=false)]
        public string IsSSL { get; set; }

        /// <summary>
        /// <para>The field that is used to indicate the logon name of a user on the LDAP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userNameAttr</para>
        /// </summary>
        [NameInMap("LoginNameMapping")]
        [Validation(Required=false)]
        public string LoginNameMapping { get; set; }

        /// <summary>
        /// <para>The field that is used to indicate the mobile phone number of a user on the LDAP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobileAttr</para>
        /// </summary>
        [NameInMap("MobileMapping")]
        [Validation(Required=false)]
        public string MobileMapping { get; set; }

        /// <summary>
        /// <para>The field that is used to indicate the name of a user on the LDAP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nameAttr</para>
        /// </summary>
        [NameInMap("NameMapping")]
        [Validation(Required=false)]
        public string NameMapping { get; set; }

        /// <summary>
        /// <para>The password of the account that is used for the LDAP server. You must configure a password when you configure LDAP authentication. If you leave this parameter empty when you modify the settings of LDAP authentication, the current password is used.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port that is used to access the LDAP server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>389</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The address of the LDAP server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Server")]
        [Validation(Required=false)]
        public string Server { get; set; }

        /// <summary>
        /// <para>The address of the secondary LDAP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("StandbyServer")]
        [Validation(Required=false)]
        public string StandbyServer { get; set; }

    }

}
