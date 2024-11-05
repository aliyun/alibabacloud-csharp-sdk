// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceLDAPAuthServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The settings of LDAP authentication.</para>
        /// </summary>
        [NameInMap("LDAP")]
        [Validation(Required=false)]
        public GetInstanceLDAPAuthServerResponseBodyLDAP LDAP { get; set; }
        public class GetInstanceLDAPAuthServerResponseBodyLDAP : TeaModel {
            /// <summary>
            /// <para>The account of the LDAP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn=Manager,dc=test,dc=com</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The Base distinguished name (DN).</para>
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
            /// <para>(&amp;(objectClass=top))</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// <para>Indicates whether passwords are required. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: required</description></item>
            /// <item><description><b>false</b>: not required</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public string HasPassword { get; set; }

            /// <summary>
            /// <para>Indicates whether SSL is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: supported</description></item>
            /// <item><description><b>false</b>: not supported</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSSL")]
            [Validation(Required=false)]
            public bool? IsSSL { get; set; }

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
            /// <para>The port that is used to access the LDAP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>389</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <para>The address of the LDAP server.</para>
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

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C60E741-102D-5E8F-9710-B06D3F0183FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
