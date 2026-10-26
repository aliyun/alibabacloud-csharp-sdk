// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceMetricsRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1s1j103lo6****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The monitoring metrics of the instance. You can specify multiple metric keys and separate them with commas (,). A maximum of 30 metric keys can be specified.</para>
        /// <para>You can call the DescribeAvailableMetrics operation to query the keys of enhanced monitoring metrics.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>os.cpu_usage.sys.avg,os.cpu_usage.user.avg</para>
        /// </summary>
        [NameInMap("MetricsConfig")]
        [Validation(Required=false)]
        public string MetricsConfig { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The scope of the modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instance</b>: instance level. The modification applies only to cloud disk instance.</description></item>
        /// <item><description><b>region</b>: region level. The modification applies to all ApsaraDB RDS for PostgreSQL instances that use the same storage type as cloud disk instance in the current region. For example, if cloud disk instance uses cloud disks, the modification applies to all ApsaraDB RDS for PostgreSQL instances that use cloud disks in the current region.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
