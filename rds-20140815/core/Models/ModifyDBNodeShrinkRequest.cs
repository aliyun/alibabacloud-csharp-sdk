// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBNodeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment.
        /// Valid values:</para>
        /// <ol>
        /// <item><description><para><b>true</b>: Automatic payment is enabled. Make sure that your account balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Only an order is generated and no payment is made.</para>
        /// </description></item>
        /// </ol>
        /// <remarks>
        /// <para>Default value: true. If your payment method has an insufficient balance, you can set this parameter to false. In this case, an unpaid order is generated, and you can log on to the ApsaraDB RDS console to complete the payment.</para>
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
        /// <para>The new instance storage capacity. Unit: GB. For details, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance specifications</a>.</para>
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
        /// <para>This parameter applies to ApsaraDB RDS for MySQL Cluster Edition instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public string DBNodeShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a precheck before the node modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: A precheck is performed, but the modification is not executed. The check items include request parameters, request format, business limits, and inventory.</description></item>
        /// <item><description><b>false</b>: A normal request is sent, and the modification is executed immediately after the request passes the precheck. This is the default value.</description></item>
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
        /// <item><description><b>Immediate</b> (default): The modifications take effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The modifications take effect within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
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
        /// <para>Specifies whether to asynchronously execute the modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Only an order is generated, and the modification is executed asynchronously. This is the default value.</description></item>
        /// <item><description><b>false</b>: The modification is executed synchronously after the request passes the check.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: true. The modification is executed asynchronously. If you set this parameter to false, the modification is executed synchronously, and the API response time is relatively long.</para>
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
