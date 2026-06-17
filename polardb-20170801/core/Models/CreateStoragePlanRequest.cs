// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateStoragePlanRequest : TeaModel {
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate this token on your client. The token must be unique across different requests. It is case-sensitive and can contain up to 64 ASCII characters.</para>
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
        /// <para>The unit of the subscription duration for the storage plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// <item><description><para><b>Year</b></para>
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
        /// <para>The capacity of the storage plan, in GB. Valid values: 50, 100, 200, 300, 500, 1,000, 2,000, 3,000, 5,000, 10,000, 15,000, 20,000, 25,000, 30,000, 50,000, 100,000, and 200,000.</para>
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
        /// <item><description><para><b>Mainland</b>: For use in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>Overseas</b>: For use in China (Hong Kong) and regions outside China.</para>
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
        /// <para>The subscription duration of the storage plan.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>Period</b> is set to <b>Month</b>, the value ranges from 1 to 9.</para>
        /// </description></item>
        /// <item><description><para>If <b>Period</b> is set to <b>Year</b>, the valid values are 1, 2, 3, and 5.</para>
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
