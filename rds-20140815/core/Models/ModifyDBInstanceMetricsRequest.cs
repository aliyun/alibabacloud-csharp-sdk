// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1s1j103lo6****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The monitoring metrics to configure for the instance. You can specify multiple metric keys separated by commas (,). A maximum of 30 metric keys can be specified.</para>
        /// <para>You can call the DescribeAvailableMetrics operation to obtain the enhanced monitoring metric keys.</para>
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
        /// <item><description><b>instance</b>: instance level. The modification is applied only to cloud disk instance.</description></item>
        /// <item><description><b>region</b>: region level. The modification is applied to all ApsaraDB RDS for PostgreSQL instances that use the same storage type as cloud disk instance in the current region. For example, if cloud disk instance uses cloud disks, the modification is applied to all ApsaraDB RDS for PostgreSQL instances with cloud disks in the current region.</description></item>
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
