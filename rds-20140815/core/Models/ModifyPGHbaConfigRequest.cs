// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyPGHbaConfigRequest : TeaModel {
        /// <summary>
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1lymyn1v3i****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of AD domain service information entries.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HbaItem")]
        [Validation(Required=false)]
        public List<ModifyPGHbaConfigRequestHbaItem> HbaItem { get; set; }
        public class ModifyPGHbaConfigRequestHbaItem : TeaModel {
            /// <summary>
            /// <para>The IP address or CIDR block from which users are allowed to connect to the database. A value of 0.0.0.0/0 allows users to connect from any IP address.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The name of the database. Specifies the databases that users are allowed to access. A value of all allows users to access all databases.</para>
            /// <para>To specify multiple databases, separate them with commas (,).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The subnet mask. If <b>Address</b> is an IP address, you can use this parameter to specify the subnet mask for that IP address.</para>
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
            /// <para>The optional parameters for the authentication method. This parameter is required when LDAP authentication is used. For more information about this parameter, see <a href="https://www.postgresql.org/docs/11/auth-methods.html">Authentication Methods</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldapserver=192.168.XX.XX ldapbasedn=&quot;CN=Users,DC=pgsqldomain,DC=net&quot; ldapbinddn=&quot;CN=pgadminuser,CN=Users,DC=pgsqldomain,DC=net&quot; ldapbindpasswd=&quot;Test123!&quot; ldapsearchattribute=&quot;sAMAccountName&quot;</para>
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public string Option { get; set; }

            /// <summary>
            /// <para>The priority of the record. Valid values: 0 to 10000. A value of 0 indicates the highest priority.</para>
            /// <para>This parameter identifies each record. When adding a record, the PriorityId value must not duplicate that of any existing record. When modifying or deleting a record, the PriorityId value must match that of an existing record to locate the target record.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public int? PriorityId { get; set; }

            /// <summary>
            /// <para>The connection type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>host</b>: The record matches TCP/IP connections, including both SSL and non-SSL connections.</description></item>
            /// <item><description><b>hostssl</b>: The record matches only TCP/IP connections established over SSL.</description></item>
            /// <item><description><b>hostnossl</b>: The record matches only TCP/IP connections established without SSL.<remarks>
            /// <para>If you use the hostssl connection type, you must enable SSL encryption. For more information, see <a href="https://help.aliyun.com/document_detail/229518.html">SSL encryption</a>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The users that are allowed to access the database. Enter the usernames of the instance. To specify multiple users, separate them with commas (,).</para>
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
        /// <para>The operation type. The following methods are supported for modifying AD domain service information:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: Adds one or more records. The PriorityId value of the new records cannot duplicate that of existing records.</description></item>
        /// <item><description><b>delete</b>: Deletes one or more records. Records whose <b>PriorityId</b> values match those specified are deleted from the current configuration.</description></item>
        /// <item><description><b>modify</b>: Modifies one or more records. Records whose <b>PriorityId</b> values match those specified are modified in the current configuration.</description></item>
        /// <item><description><b>update</b>: Performs a full update. The current configuration is overwritten with the configuration you specify.</description></item>
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
