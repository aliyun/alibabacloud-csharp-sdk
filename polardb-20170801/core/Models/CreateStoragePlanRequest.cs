// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateStoragePlanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Uses coupons.</description></item>
        /// <item><description>false: Does not use coupons.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token is case-sensitive and can contain only ASCII characters. The token can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f5********************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The unit of the storage plan duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b>: month.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: year.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The coupon code. If this parameter is not specified, the default coupon is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The capacity of the storage plan. Unit: GB. Valid values: 50, 100, 200, 300, 500, 1000, 2000, 3000, 5000, 10000, 15000, 20000, 25000, 30000, 50000, 100000, and 200000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// <para>The type of the storage plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Mainland</b>: general-purpose, applicable in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>Overseas</b>: general-purpose, applicable in Hong Kong (China) and outside China.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mainland</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The duration of the storage plan.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>Period</b> is set to <b>Month</b>, the value ranges from 1 to 9.</para>
        /// </description></item>
        /// <item><description><para>If <b>Period</b> is set to <b>Year</b>, valid values are 1, 2, 3, and 5.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

    }

}
