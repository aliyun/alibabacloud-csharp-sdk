// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyReadWriteSplittingConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the read/write splitting endpoint. The prefix must be unique and can contain lowercase letters and hyphens (-). It must start with a letter and cannot exceed 30 characters in length.</para>
        /// <remarks>
        /// <para>By default, the prefix is in the format of &quot;instance name + rw&quot;.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-m5****rw.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The primary instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The read weight distribution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: Read weights are automatically assigned based on instance specifications.</description></item>
        /// <item><description><b>Custom</b>: Read weights are manually assigned.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify at least one of <b>MaxDelayTime</b> or <b>DistributionType</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        /// <summary>
        /// <para>The latency threshold, in seconds. If the latency of a read-only instance exceeds this threshold, read traffic is not routed to the instance. If you do not specify this parameter, the current value is retained.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The <b>MaxDelayTime</b> parameter is not applicable to SQL Server 2017 on RDS Cluster Edition instances.</description></item>
        /// <item><description>You must specify at least one of <b>MaxDelayTime</b> or <b>DistributionType</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MaxDelayTime")]
        [Validation(Required=false)]
        public string MaxDelayTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The port number of the read/write splitting endpoint.</para>
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
        /// <para>The read weight distribution. This parameter specifies the read request weights for the primary instance and read-only instances. The value must be a multiple of 100 and cannot exceed 10000.</para>
        /// <list type="bullet">
        /// <item><description>Format for ApsaraDB RDS instances: <c>{&quot;&lt;Read-only instance ID&gt;&quot;:&lt;Weight&gt;,&quot;master&quot;:&lt;Weight&gt;,&quot;slave&quot;:&lt;Weight&gt;}</c></description></item>
        /// <item><description>Format for MyBASE instances: <c>[{&quot;instanceName&quot;:&quot;&lt;Primary instance ID&gt;&quot;,&quot;weight&quot;:&lt;Weight&gt;,&quot;role&quot;:&quot;master&quot;},{&quot;instanceName&quot;:&quot;&lt;Primary instance ID&gt;&quot;,&quot;weight&quot;:&lt;Weight&gt;,&quot;role&quot;:&quot;slave&quot;},{&quot;instanceName&quot;:&quot;&lt;Read-only instance ID&gt;&quot;,&quot;weight&quot;:&lt;Weight&gt;,&quot;role&quot;:&quot;master&quot;}]</c></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>DistributionType</b> is set to <b>Custom</b>.</description></item>
        /// <item><description>This parameter is invalid when <b>DistributionType</b> is set to <b>Standard</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;rm-bp1****&quot;: 800,
        ///       &quot;master&quot;: 400,
        ///       &quot;slave&quot;: 400
        /// }</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
