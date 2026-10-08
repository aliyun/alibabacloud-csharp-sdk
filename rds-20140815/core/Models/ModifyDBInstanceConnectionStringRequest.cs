// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The TDS port number for Babelfish for RDS PostgreSQL.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for RDS PostgreSQL, see <a href="https://help.aliyun.com/document_detail/428613.html">Introduction to Babelfish</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1433</para>
        /// </summary>
        [NameInMap("BabelfishPort")]
        [Validation(Required=false)]
        public string BabelfishPort { get; set; }

        /// <summary>
        /// <para>The prefix of the endpoint. You can modify only the prefix of the value specified by the <b>CurrentConnectionString</b> parameter.</para>
        /// <remarks>
        /// <para>The prefix must be 8 to 64 characters in length and cannot contain Chinese characters or special characters (~!#%^&amp;*=+\|{};:\&quot;&quot;,&lt;&gt;/?). The prefix can contain letters, digits, and hyphens (-).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-****</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The current endpoint of the instance. The endpoint can be a public endpoint or internal endpoint, or a classic network connectivity endpoint in hybrid access mode.</para>
        /// <remarks>
        /// <para>Modification of read/write splitting connection endpoints is not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5x****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CurrentConnectionString")]
        [Validation(Required=false)]
        public string CurrentConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the group to which the dedicated cluster MySQL general-purpose instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgc-bp1tkv8****</para>
        /// </summary>
        [NameInMap("GeneralGroupName")]
        [Validation(Required=false)]
        public string GeneralGroupName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The PgBouncer port number.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances. If PgBouncer is enabled, you can modify the PgBouncer port number.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6432</para>
        /// </summary>
        [NameInMap("PGBouncerPort")]
        [Validation(Required=false)]
        public string PGBouncerPort { get; set; }

        /// <summary>
        /// <para>The target port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the virtual IP address (VIP) when swapping the endpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The VIP is retained.</description></item>
        /// <item><description><b>false</b> (default): The VIP is not retained.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RetainVip")]
        [Validation(Required=false)]
        public bool? RetainVip { get; set; }

        /// <summary>
        /// <para>The instance ID of the target ApsaraDB RDS for PostgreSQL instance with which you want to swap the endpoint.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1206s14p3o****</para>
        /// </summary>
        [NameInMap("TargetDBInstanceId")]
        [Validation(Required=false)]
        public string TargetDBInstanceId { get; set; }

    }

}
