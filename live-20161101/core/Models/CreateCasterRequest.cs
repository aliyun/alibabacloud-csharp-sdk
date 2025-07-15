// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateCasterRequest : TeaModel {
        /// <summary>
        /// <para>The name of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveCaster****</para>
        /// </summary>
        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        /// <summary>
        /// <para>The preset resolution of the production studio. If the subscription billing method is used, this parameter supports the following valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lp_ld</b>: low definition</description></item>
        /// <item><description><b>lp_sd</b>: standard definition</description></item>
        /// <item><description><b>lp_hd</b>: high definition</description></item>
        /// <item><description><b>lp_ud</b>: ultra high definition</description></item>
        /// <item><description><b>lp_ld_v</b>: low definition (portrait mode)</description></item>
        /// <item><description><b>lp_sd_v</b>: standard definition (portrait mode)</description></item>
        /// <item><description><b>lp_hd_v</b>: high definition (portrait mode)</description></item>
        /// <item><description><b>lp_ud_v</b>: ultra high definition (portrait mode)</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the pay-as-you-go billing method is used, you must call the <a href="https://help.aliyun.com/document_detail/60271.html">SetCasterConfig</a> operation to specify the resolution.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lp_sd</para>
        /// </summary>
        [NameInMap("CasterTemplate")]
        [Validation(Required=false)]
        public string CasterTemplate { get; set; }

        /// <summary>
        /// <para>The billing method. Only the pay-as-you-go billing method is supported.**** Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription. This billing method is not yet supported.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can specify a custom value for this parameter, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The expiration time of the production studio. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> This parameter is valid only if you set the <b>ChargeType</b> parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-22T12:10:10Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The type of the production studio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: general mode</description></item>
        /// <item><description><b>6</b>: playlist mode (for carousel playback)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NormType")]
        [Validation(Required=false)]
        public int? NormType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The time when the production studio was purchased. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> This parameter is valid only if you set the <b>ChargeType</b> parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-20T12:10:10Z</para>
        /// </summary>
        [NameInMap("PurchaseTime")]
        [Validation(Required=false)]
        public string PurchaseTime { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzw******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCasterRequestTag> Tag { get; set; }
        public class CreateCasterRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
