// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete automatic payment. Valid values:</para>
        /// <ol>
        /// <item><description><para><b>true</b>: Automatic payment is automatically completed. Make sure that your account balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: An order is generated but no payment is made.</para>
        /// </description></item>
        /// </ol>
        /// <remarks>
        /// <para>Default value: true. If your payment method has insufficient balance, set AutoPay to false. In this case, an unpaid order is generated. You can log on to the ApsaraDB RDS console to complete automatic payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1k8s41l2o52****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The new instance storage capacity. Unit: GB. For details, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public string DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The node information.</para>
        /// <remarks>
        /// <para>This parameter is used for MySQL Cluster Edition instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<ModifyDBNodeRequestDBNode> DBNode { get; set; }
        public class ModifyDBNodeRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.n2.medium.xc</para>
            /// </summary>
            [NameInMap("classCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rn-6256r4a87xvv7****</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this node modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: A dry run is performed without executing the modification. The system checks items such as request parameters, request format, business limits, and inventory.</description></item>
        /// <item><description><b>false</b>: A request is sent. After the request passes the check, the modification is directly executed. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default): The modification takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The modification takes effect during the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to asynchronously execute the provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request only submits an order, and the modification is asynchronously executed. This is the default value.</description></item>
        /// <item><description><b>false</b>: After the request passes the check, the modification is directly executed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: true. The modification is asynchronously executed. If you set this parameter to false, the modification is synchronously executed, and the response time is relatively longer.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ProduceAsync")]
        [Validation(Required=false)]
        public bool? ProduceAsync { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
