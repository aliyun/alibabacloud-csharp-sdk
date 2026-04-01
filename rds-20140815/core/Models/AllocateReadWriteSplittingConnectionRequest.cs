// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AllocateReadWriteSplittingConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the read-only routing endpoint. The prefix must be unique. It can be up to 30 characters in length and can contain lowercase letters and hyphens (-). It must start with a lowercase letter.</para>
        /// <remarks>
        /// <para> The default prefix consists of the name of the primary instance followed by the letters rw.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rr-m5exxxxx-rw.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The primary instance ID. You can call the DescribeDBInstances operation to query the primary instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The method that is used to assign read weights. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: The system automatically assigns read weights to the primary and read-only instances based on the specifications of these instances.</description></item>
        /// <item><description><b>Custom</b>: You must manually assign a read weight to each instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        /// <summary>
        /// <para>The threshold of the latency that is allowed on the read-only instances. Valid values: 0 to 7200. Default value: 30. Unit: seconds.</para>
        /// <remarks>
        /// <para> If the latency on a read-only instance exceeds the specified threshold, ApsaraDB RDS does not forward read requests to the read-only instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxDelayTime")]
        [Validation(Required=false)]
        public string MaxDelayTime { get; set; }

        /// <summary>
        /// <para>The network type of the read-only routing endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b></description></item>
        /// <item><description><b>Intranet</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is Intranet. Make sure that the network type of the read-only routing endpoint is the same as that of the primary instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The port that is associated with the read-only routing endpoint. Valid values: 1000 to 5999. Default value: 1433.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1433</para>
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
        /// <para>The read weights of the primary instance and its read-only instances. The read weight is increased in increments of 100. The maximum value is 10000.</para>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS instances, the value of this parameter is in the following format: <c>{&quot;&lt;ID of the read-only instance &gt;&quot;:&lt;Weight&gt;,&quot;master&quot;:&lt;Weight&gt;,&quot;slave&quot;:&lt;Weight&gt;}</c>.</description></item>
        /// <item><description>For ApsaraDB MyBase instances, the value of this parameter is in the following format: <c>[{&quot;instanceName&quot;:&quot;&lt;Primary instance ID&gt;&quot;,&quot;weight&quot;:&lt;Weight&gt;,&quot;role&quot;:&quot;master&quot;},{&quot;instanceName&quot;:&quot;&lt;Primary instance ID&gt;&quot;,&quot;weight&quot;:&lt;Weight&gt;,&quot;role&quot;:&quot;slave&quot;},{&quot;instanceName&quot;:&quot;&lt;Read-only instance ID&gt;&quot;,&quot;weight&quot;:&lt;Weight&gt;,&quot;role&quot;:&quot;master&quot;}]</c></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter must be specified when <b>DistributionType</b> is set to <b>Custom</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>DistributionType</b> is set to <b>Standard</b>, this parameter is invalid.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rm-bp1**********&quot;:800,&quot;master&quot;:400,&quot;slave&quot;:400}</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
