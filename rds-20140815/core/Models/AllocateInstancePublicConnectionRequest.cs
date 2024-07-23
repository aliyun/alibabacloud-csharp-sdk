// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AllocateInstancePublicConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The Tabular Data Stream (TDS) port of the instance for which Babelfish is enabled.</para>
        /// <remarks>
        /// <para>This parameter applies only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see <a href="https://help.aliyun.com/document_detail/428613.html">Introduction to Babelfish</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1433</para>
        /// </summary>
        [NameInMap("BabelfishPort")]
        [Validation(Required=false)]
        public string BabelfishPort { get; set; }

        /// <summary>
        /// <para>The prefix of the public endpoint. A valid public endpoint is in the following format: <c>Prefix.Database engine.rds.aliyuncs.com</c>. Example: <c>test1234.mysql.rds.aliyuncs.com</c>.</para>
        /// <remarks>
        /// <para>The value can be 5 to 40 characters in length and can contain letters, digits, and hyphens (-). The value cannot contain any of the following characters: ~ ! # % ^ &amp; \* = + | {} ; : \&quot; &quot; , &lt;&gt; / ?</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1234</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the dedicated cluster to which the instance belongs. This parameter is available only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgc-bp1tkv8*****</para>
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
        /// <para>The PgBouncer port.</para>
        /// <remarks>
        /// <para>This parameter is available only for instances that run PostgreSQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6432</para>
        /// </summary>
        [NameInMap("PGBouncerPort")]
        [Validation(Required=false)]
        public string PGBouncerPort { get; set; }

        /// <summary>
        /// <para>The public port of the instance. Valid values: <b>1000 to 5999</b>.</para>
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

    }

}
