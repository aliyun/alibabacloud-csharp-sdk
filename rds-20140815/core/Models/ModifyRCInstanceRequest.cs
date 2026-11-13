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
        /// <item><description><b>true</b>: enables automatic payment. This is the default value. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: generates an unpaid order without deducting fees.<remarks>
        /// <para>If the balance of your payment method is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.</para>
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
        /// <item><description><b>true</b>: automatically uses coupons. This is the default value.</description></item>
        /// <item><description><b>false</b>: does not automatically use coupons.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use a coupon and then downgrade the instance type, the amount deducted by the voucher is not refunded.</para>
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
        /// <para>The scaling direction. Valid values:</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter. The system automatically determines whether to upgrade or downgrade the instance type. If you specify this parameter, follow these rules:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Up</b>: upgrades the instance type. This is the default value. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>Down</b>: downgrades the instance type. Set this parameter to Down when the instance type specified by InstanceType is lower than the current instance type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a precheck on this operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a precheck without modifying the instance type. The system checks items such as request parameters, request format, service limits, and inventory.</description></item>
        /// <item><description><b>false</b>: sends a normal request and modifies the instance type after the request passes the precheck. This is the default value.</description></item>
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
        /// <para>The destination instance type. For more information about the instance types supported by RDS Target instances, see <a href="https://help.aliyun.com/document_detail/2844823.html">RDS Target instance types</a>.</para>
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
        /// <item><description>If <b>RebootWhenFinished</b> is set to <b>false</b> and the instance is in the <b>Running</b> state, you <b>must</b> specify a restart time within 48 hours.</description></item>
        /// <item><description>Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-03T12:05Z</para>
        /// </summary>
        [NameInMap("RebootTime")]
        [Validation(Required=false)]
        public string RebootTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately restart the instance after the instance type change is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: immediately restarts the instance. This is the default value.</description></item>
        /// <item><description><b>false</b>: does not immediately restart the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the instance is in the <b>Stopped</b> state, it remains in the Stopped state and is not restarted even if you set <c>RebootWhenFinished</c> to true.</para>
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
