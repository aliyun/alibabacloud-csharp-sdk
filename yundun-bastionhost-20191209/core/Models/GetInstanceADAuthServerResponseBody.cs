// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceADAuthServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The Active Directory (AD) authentication configurations.</para>
        /// </summary>
        [NameInMap("AD")]
        [Validation(Required=false)]
        public GetInstanceADAuthServerResponseBodyAD AD { get; set; }
        public class GetInstanceADAuthServerResponseBodyAD : TeaModel {
            /// <summary>
            /// <para>The distinguished name (DN) of the server account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn=Manager,dc=test,dc=com</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The base DN used to connect to the AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc=test,dc=com</para>
            /// </summary>
            [NameInMap("BaseDN")]
            [Validation(Required=false)]
            public string BaseDN { get; set; }

            /// <summary>
            /// <para>The domain on the AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The name of the field that maps to the user email address on the AD server.</para>
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
            /// <para>(&amp;(objectClass=top))</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// <para>Specifies whether a password is set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A password is set.</description></item>
            /// <item><description><b>false</b>: No password is set.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            /// <summary>
            /// <para>Specifies whether the server is the default AD authentication server. A value of true indicates that the server is the default AD authentication server, and a value of false indicates that the server is not the default AD authentication server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

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
            public bool? IsSSL { get; set; }

            /// <summary>
            /// <para>Specifies whether email addresses are synchronized. A value of true indicates that email addresses are synchronized, and a value of false indicates that email addresses are not synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSyncEmailAttr")]
            [Validation(Required=false)]
            public bool? IsSyncEmailAttr { get; set; }

            /// <summary>
            /// <para>Specifies whether mobile phone numbers are synchronized. A value of true indicates that mobile phone numbers are synchronized, and a value of false indicates that mobile phone numbers are not synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSyncMobileAttr")]
            [Validation(Required=false)]
            public bool? IsSyncMobileAttr { get; set; }

            /// <summary>
            /// <para>Specifies whether display names are synchronized. A value of true indicates that display names are synchronized, and a value of false indicates that display names are not synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSyncNameAttr")]
            [Validation(Required=false)]
            public bool? IsSyncNameAttr { get; set; }

            /// <summary>
            /// <para>Specifies whether the organization to which a user belongs is synchronized as a user group. A value of true indicates that the organization is synchronized as a user group, and a value of false indicates that the organization is not synchronized as a user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSyncOuAsUserGroup")]
            [Validation(Required=false)]
            public bool? IsSyncOuAsUserGroup { get; set; }

            /// <summary>
            /// <para>The time when the user snapshot was last synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LatestSyncTime")]
            [Validation(Required=false)]
            public long? LatestSyncTime { get; set; }

            /// <summary>
            /// <para>The name of the field that maps to the user mobile phone number on the AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mobileAttr</para>
            /// </summary>
            [NameInMap("MobileMapping")]
            [Validation(Required=false)]
            public string MobileMapping { get; set; }

            /// <summary>
            /// <para>The name of the field that maps to the username on the AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nameAttr</para>
            /// </summary>
            [NameInMap("NameMapping")]
            [Validation(Required=false)]
            public string NameMapping { get; set; }

            /// <summary>
            /// <para>The port of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>389</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <para>The address of the server.</para>
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
            /// <para>The interval for automatic synchronization of user snapshots. Unit: hours. Valid values: 0, and 4 to 168. A value of 0 indicates that automatic synchronization is disabled and no synchronization is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SyncInterval")]
            [Validation(Required=false)]
            public long? SyncInterval { get; set; }

            [NameInMap("UserSourceId")]
            [Validation(Required=false)]
            public string UserSourceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89398CFB-4EB6-4C7E-BB3C-EF213AC8FA50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
