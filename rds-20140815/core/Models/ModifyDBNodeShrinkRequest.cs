// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBNodeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete the payment. Valid values:</para>
        /// <ol>
        /// <item><description><b>true</b>: automatically completes the payment. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: does not automatically complete the payment. An unpaid order is generated.</description></item>
        /// </ol>
        /// <remarks>
        /// <para> The default value is true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to pay for the order.</para>
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
        /// <para>The new storage capacity of the instance. Unit: GB For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
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
        /// <item><description><b>cloud_essd</b>: performance level 1 (PL1) enhanced SSD (ESSD)</description></item>
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
        /// <para>The information about the node.</para>
        /// <remarks>
        /// <para> This parameter is supported for ApsaraDB RDS for MySQL instances that run RDS Cluster Edition.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public string DBNodeShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not perform the actual request. The system checks items such as the request parameters, request format, service limits, and available resources.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Effective time, value:</para>
        /// <list type="bullet">
        /// <item><description>Immediate (default value): takes effect immediately.</description></item>
        /// <item><description>MaintainTime: Effective within the operational time period, please refer to ModifyDBInstanceMaintainTime.</description></item>
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
        /// <para>Specifies whether to asynchronously perform the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): sends only the order. The operation is asynchronously performed.</description></item>
        /// <item><description><b>false</b>: sends the request. After the request passes the check, the operation is directly performed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is true, which indicates that the change operation is asynchronously performed. If you set this parameter to false, the change operation is simultaneously performed. This prolongs the response time of the operation.</para>
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
