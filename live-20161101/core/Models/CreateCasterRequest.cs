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
        /// <para>The preset resolution of the production studio. This parameter is available only for the subscription billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lp_ld</b>: low definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_sd</b>: standard definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_hd</b>: high definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_ud</b>: ultra-high definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_ld_v</b>: vertical low definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_sd_v</b>: vertical standard definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_hd_v</b>: vertical high definition.</para>
        /// </description></item>
        /// <item><description><para><b>lp_ud_v</b>: vertical ultra-high definition.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use the pay-as-you-go billing method, call the <a href="https://help.aliyun.com/document_detail/60271.html">SetCasterConfig</a> operation to set the resolution.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lp_sd</para>
        /// </summary>
        [NameInMap("CasterTemplate")]
        [Validation(Required=false)]
        public string CasterTemplate { get; set; }

        /// <summary>
        /// <para>The billing method. Only <b>PostPaid</b> is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrePaid</b>: subscription (not supported).</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b>: pay-as-you-go.</para>
        /// </description></item>
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
        /// <para>Generate a token on your client and ensure that the token is unique among different requests. The token can be up to 64 ASCII characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The expiration time of the production studio. The time is in the \<c>yyyy-MM-ddTHH:mm:ssZ\\</c> format and is displayed in UTC.</para>
        /// <remarks>
        /// <para>This parameter is available only if you set <b>ChargeType</b> to <b>PrePaid</b>.</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Standard.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Lightweight Carousel.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Virtual Studio.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Carousel (New Playlist).</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Standard.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Carousel (New Playlist).</para>
        /// </description></item>
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
        /// <para>The purchase time of the production studio. The time is in the \<c>yyyy-MM-ddTHH:mm:ssZ\\</c> format and is displayed in UTC.</para>
        /// <remarks>
        /// <para>This parameter is available only if you set <b>ChargeType</b> to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-20T12:10:10Z</para>
        /// </summary>
        [NameInMap("PurchaseTime")]
        [Validation(Required=false)]
        public string PurchaseTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group?</a>.</para>
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
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
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
