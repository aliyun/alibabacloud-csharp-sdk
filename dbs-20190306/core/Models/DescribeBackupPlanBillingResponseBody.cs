// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanBillingResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This backupPlan can\&quot;t support this action</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The billing information of the backup schedule.</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public DescribeBackupPlanBillingResponseBodyItem Item { get; set; }
        public class DescribeBackupPlanBillingResponseBodyItem : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PREPAY</description></item>
            /// <item><description>POSTPAY</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("BuyChargeType")]
            [Validation(Required=false)]
            public string BuyChargeType { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the instance was purchased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554560477000</para>
            /// </summary>
            [NameInMap("BuyCreateTimestamp")]
            [Validation(Required=false)]
            public long? BuyCreateTimestamp { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the instance expires.</para>
            /// <remarks>
            /// <para>This parameter is available only if the value of the BuyChargeType parameter is PREPAY.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1554560477000</para>
            /// </summary>
            [NameInMap("BuyExpiredTimestamp")]
            [Validation(Required=false)]
            public long? BuyExpiredTimestamp { get; set; }

            /// <summary>
            /// <para>The specifications of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>micro</para>
            /// </summary>
            [NameInMap("BuySpec")]
            [Validation(Required=false)]
            public string BuySpec { get; set; }

            /// <summary>
            /// <para>The size of the built-in storage for storing incremental backup data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12134</para>
            /// </summary>
            [NameInMap("ContStorageSize")]
            [Validation(Required=false)]
            public long? ContStorageSize { get; set; }

            /// <summary>
            /// <para>The size of the built-in storage for storing full backup data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13123</para>
            /// </summary>
            [NameInMap("FullStorageSize")]
            [Validation(Required=false)]
            public long? FullStorageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance expired.</para>
            /// <remarks>
            /// <para>This parameter is available only if the value of the BuyChargeType parameter is PREPAY.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance has no backup traffic limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFreeBytesUnlimited")]
            [Validation(Required=false)]
            public bool? IsFreeBytesUnlimited { get; set; }

            /// <summary>
            /// <para>The total paid backup traffic in the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213213</para>
            /// </summary>
            [NameInMap("PaiedBytes")]
            [Validation(Required=false)]
            public long? PaiedBytes { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the billing cycle of free backup traffic ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554560477000</para>
            /// </summary>
            [NameInMap("QuotaEndTimestamp")]
            [Validation(Required=false)]
            public long? QuotaEndTimestamp { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the billing cycle of free backup traffic starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554560477000</para>
            /// </summary>
            [NameInMap("QuotaStartTimestamp")]
            [Validation(Required=false)]
            public long? QuotaStartTimestamp { get; set; }

            /// <summary>
            /// <para>The total free backup traffic in the current month.</para>
            /// <remarks>
            /// <para>This parameter is available only if the value of the BuyChargeType parameter is PREPAY and the value of the IsFreeBytesUnlimited parameter is false.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>13123</para>
            /// </summary>
            [NameInMap("TotalFreeBytes")]
            [Validation(Required=false)]
            public long? TotalFreeBytes { get; set; }

            /// <summary>
            /// <para>The paid full backup traffic in the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1312313</para>
            /// </summary>
            [NameInMap("UsedFullBytes")]
            [Validation(Required=false)]
            public long? UsedFullBytes { get; set; }

            /// <summary>
            /// <para>The paid incremental backup traffic in the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131231</para>
            /// </summary>
            [NameInMap("UsedIncrementBytes")]
            [Validation(Required=false)]
            public long? UsedIncrementBytes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB4DFD5E-3618-498D-BE35-4DBEA0072122</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
