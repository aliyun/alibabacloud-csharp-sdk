// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyPGHbaConfigRequest : TeaModel {
        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1lymyn1v3i****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>An array that consists of the details of the AD domain services.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HbaItem")]
        [Validation(Required=false)]
        public List<ModifyPGHbaConfigRequestHbaItem> HbaItem { get; set; }
        public class ModifyPGHbaConfigRequestHbaItem : TeaModel {
            /// <summary>
            /// <para>The IP addresses from which the specified users can access the specified databases. If you set this parameter to 0.0.0.0/0, the specified users are allowed to access the specified databases from all IP addresses.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The name of the database. If you set this parameter to all, the specified users are allowed to access all databases on the instance.</para>
            /// <para>If you specify multiple entries, separate the entries with commas (,).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The mask of the IP address. If the value of the <b>Address</b> parameter is an IP address, you can use this parameter to specify the mask of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            /// <summary>
            /// <para>The authentication method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>trust</b></description></item>
            /// <item><description><b>reject</b></description></item>
            /// <item><description><b>scram-sha-256</b></description></item>
            /// <item><description><b>md5</b></description></item>
            /// <item><description><b>password</b></description></item>
            /// <item><description><b>gss</b></description></item>
            /// <item><description><b>sspi</b></description></item>
            /// <item><description><b>ldap</b></description></item>
            /// <item><description><b>radius</b></description></item>
            /// <item><description><b>cert</b></description></item>
            /// <item><description><b>pam</b></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The options of the authentication method. In this topic, LDAP is used as an example. You must configure this parameter. For more information, see <a href="https://www.postgresql.org/docs/11/auth-methods.html">Authentication Methods</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldapserver=The private IP address of the ECS instance ldapbasedn=&quot;CN=Users,DC=pgsqldomain,DC=net&quot; ldapbinddn=&quot;CN=The username of the administrator user of the AD domain controller, CN=Users,DC=pgsqldomain,DC=net&quot; ldapbindpasswd=&quot;The password of the administrator user of the AD domain controller&quot; ldapsearchattribute=&quot;sAMAccountName&quot;</para>
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public string Option { get; set; }

            /// <summary>
            /// <para>The priority of the record. If you set this parameter to 0, the record has the highest priority. Valid values: 0 to 10000.</para>
            /// <para>This parameter is used to identify each record. When you add a record, the value of the PriorityId parameter for the new record must be different from the value of the PriorityId parameter of any existing record. When you modify or delete a record, you must also modify or delete the value of the PriorityId parameter for this record.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public int? PriorityId { get; set; }

            /// <summary>
            /// <para>The connection type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>host</b>: The record matches TCP/IP connections, including SSL connections and non-SSL connections.</description></item>
            /// <item><description><b>hostssl</b>: The record matches only TCP/IP connections that are established over SSL.</description></item>
            /// <item><description><b>hostnossl</b>: The record matches only TCP/IP connections that are not established over SSL connections.</description></item>
            /// </list>
            /// <remarks>
            /// <para> You can set this parameter to hostssl only when SSL encryption is enabled for the instance. For more information, see Configure SSL encryption for an ApsaraDB RDS for PostgreSQL instance.<a href="~~229518~~"></a></para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user who is allowed to access the specified databases. You must specify the user that is used to log on to the RDS instance. If you specify multiple entries, separate the entries with commas (,).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldapuser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The method that you use to modify the pg_hba.conf file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: adds one or more records. If you use this method, make sure that the value of the PriorityId parameter for each new record is different from the value of the PriorityId parameter for any existing record.</description></item>
        /// <item><description><b>delete</b>: deletes one or more records. If you use this method, the record that corresponds to the specified value of the <b>PriorityId</b> parameter is deleted from the pg_hba.conf file.</description></item>
        /// <item><description><b>modify</b>: modifies one or more records. If you use this method, the record that corresponds to the specified value of the <b>PriorityId</b> parameter is modified.</description></item>
        /// <item><description><b>update</b>: overwrites the existing configuration in the pg_hba.conf file by using the new configuration.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
