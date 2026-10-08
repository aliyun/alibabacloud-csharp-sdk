// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: An order is generated but payment is not automatically made.<remarks>
        /// <para>If your payment method balance is insufficient, set the parameter AutoPay to false. An unpaid order is generated, and you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Coupons are automatically used.</description></item>
        /// <item><description><b>false</b>: Coupons are not used.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use coupons and then perform a downgrade, the amount deducted by coupons is not refunded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The type of the Upgrade/Downgrade. Valid values:</para>
        /// <remarks>
        /// <para>This parameter does not need to be uploaded. The system can automatically determine whether the change is an upgrade or a downgrade. If you upload this parameter, follow the rules below.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Up</b> (default): Upgrades the instance type. Make sure that your account payment method balance is sufficient.</description></item>
        /// <item><description><b>Down</b>: Downgrades the instance type. Set Direction to down when the instance type specified by InstanceType is lower than the current instance type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Performs a dry run without creating the instance. The system checks items such as the request parameters, request format, service limits, and available resources.</description></item>
        /// <item><description><b>false</b> (default): Sends the request. If the request passes the check, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target instance type. For information about the instance types supported by RDS Custom instances, see <a href="https://help.aliyun.com/document_detail/2844823.html">RDS Custom instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.i8.large.2cm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72329885****</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The restart time of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If <b>RebootWhenFinished</b> is set to <b>false</b> and the instance status is <b>Running</b>, you <b>must</b> set a restart time within 48 hours.</description></item>
        /// <item><description>The time follows the ISO 8601 standard in UTC+0. Format: <c>yyyy-MM-ddTHH:mmZ</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-03T12:05Z</para>
        /// </summary>
        [NameInMap("RebootTime")]
        [Validation(Required=false)]
        public string RebootTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately restart the instance after the specification change is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): The instance is restarted immediately.</description></item>
        /// <item><description><b>false</b>: The instance is not restarted.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the instance is in the <b>Stopped</b> state, the instance remains in the Stopped state and is not restarted even if you set <c>RebootWhenFinished=true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RebootWhenFinished")]
        [Validation(Required=false)]
        public bool? RebootWhenFinished { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hagnzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
