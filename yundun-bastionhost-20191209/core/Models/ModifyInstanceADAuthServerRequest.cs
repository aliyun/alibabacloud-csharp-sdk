// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyInstanceADAuthServerRequest : TeaModel {
        /// <summary>
        /// <para>The server account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn=Manager,dc=test,dc=com</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The base distinguished name (Base DN).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc=test,dc=com</para>
        /// </summary>
        [NameInMap("BaseDN")]
        [Validation(Required=false)]
        public string BaseDN { get; set; }

        /// <summary>
        /// <para>The domain on the AD server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The server attribute name that maps to the user email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emailAttr</para>
        /// </summary>
        [NameInMap("EmailMapping")]
        [Validation(Required=false)]
        public string EmailMapping { get; set; }

        /// <summary>
        /// <para>The filter condition for users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(objectClass=top)</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The instance ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>Specifies whether the AD authentication server is the default server. A value of true indicates that the server is the default AD authentication server. A value of false indicates that the server is not the default AD authentication server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public string IsDefault { get; set; }

        /// <summary>
        /// <para>Specifies whether SSL is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSSL")]
        [Validation(Required=false)]
        public string IsSSL { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the email address. A value of true indicates that the email address is synchronized. A value of false indicates that the email address is not synchronized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSyncEmailAttr")]
        [Validation(Required=false)]
        public string IsSyncEmailAttr { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the mobile phone number. A value of true indicates that the mobile phone number is synchronized. A value of false indicates that the mobile phone number is not synchronized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSyncMobileAttr")]
        [Validation(Required=false)]
        public string IsSyncMobileAttr { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the display name. A value of true indicates that the display name is synchronized. A value of false indicates that the display name is not synchronized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSyncNameAttr")]
        [Validation(Required=false)]
        public string IsSyncNameAttr { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the organization to which the user belongs as a user group. A value of true indicates that the organization is synchronized as a user group. A value of false indicates that the organization is not synchronized as a user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSyncOuAsUserGroup")]
        [Validation(Required=false)]
        public string IsSyncOuAsUserGroup { get; set; }

        /// <summary>
        /// <para>The server attribute name that maps to the user mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobileAttr</para>
        /// </summary>
        [NameInMap("MobileMapping")]
        [Validation(Required=false)]
        public string MobileMapping { get; set; }

        /// <summary>
        /// <para>The server attribute name that maps to the username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nameAttr</para>
        /// </summary>
        [NameInMap("NameMapping")]
        [Validation(Required=false)]
        public string NameMapping { get; set; }

        /// <summary>
        /// <para>The password of the server account.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port used to access the server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>389</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The address of the server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Server")]
        [Validation(Required=false)]
        public string Server { get; set; }

        /// <summary>
        /// <para>The name of the AD authentication server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD Server</para>
        /// </summary>
        [NameInMap("ServerName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

        /// <summary>
        /// <para>The address of the standby server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("StandbyServer")]
        [Validation(Required=false)]
        public string StandbyServer { get; set; }

        /// <summary>
        /// <para>The interval at which user snapshots are automatically synchronized, in hours. Valid values: 0, and 4 to 168. A value of 0 indicates that automatic synchronization is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("SyncInterval")]
        [Validation(Required=false)]
        public string SyncInterval { get; set; }

        [NameInMap("UserSourceId")]
        [Validation(Required=false)]
        public string UserSourceId { get; set; }

    }

}
