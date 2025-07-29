// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCastersResponseBody : TeaModel {
        /// <summary>
        /// <para>The production studios.</para>
        /// </summary>
        [NameInMap("CasterList")]
        [Validation(Required=false)]
        public DescribeCastersResponseBodyCasterList CasterList { get; set; }
        public class DescribeCastersResponseBodyCasterList : TeaModel {
            [NameInMap("Caster")]
            [Validation(Required=false)]
            public List<DescribeCastersResponseBodyCasterListCaster> Caster { get; set; }
            public class DescribeCastersResponseBodyCasterListCaster : TeaModel {
                /// <summary>
                /// <para>The ID of the production studio. You can specify the ID in a request to query the streaming URLs of the production studio, start the production studio, add a video resource, a layout, a component, or a playlist to the production studio, or query layouts of the production studio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
                /// </summary>
                [NameInMap("CasterId")]
                [Validation(Required=false)]
                public string CasterId { get; set; }

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
                /// <para>The resolution in which the production studio plays videos. This parameter is returned if the subscription billing method is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>lp_ld: low definition</description></item>
                /// <item><description>lp_sd: standard definition</description></item>
                /// <item><description>lp_hd: high definition</description></item>
                /// <item><description>lp_ud: ultra high definition.</description></item>
                /// <item><description>lp_ld_v: low definition (portrait mode)</description></item>
                /// <item><description>lp_sd_v: standard definition (portrait mode)</description></item>
                /// <item><description>lp_hd_v: high definition (portrait mode)</description></item>
                /// <item><description>lp_ud_v: ultra high definition (portrait mode)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>lp_ld</para>
                /// </summary>
                [NameInMap("CasterTemplate")]
                [Validation(Required=false)]
                public string CasterTemplate { get; set; }

                /// <summary>
                /// <para>Indicates whether the channel is enabled for the production studio.</para>
                /// <list type="bullet">
                /// <item><description>0: The channel is disabled.</description></item>
                /// <item><description>1: The channel is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChannelEnable")]
                [Validation(Required=false)]
                public int? ChannelEnable { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrePaid: the subscription billing method</description></item>
                /// <item><description>PostPaid: the pay-as-you-go billing method</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The client token that is used to ensure the idempotence of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
                /// </summary>
                [NameInMap("ClientTokenId")]
                [Validation(Required=false)]
                public string ClientTokenId { get; set; }

                /// <summary>
                /// <para>The time when the production studio was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-30 12:02:57.0</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The streaming duration. Format: hh:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1:02:33</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The time when the production studio expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-30 12:02:57.0</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The time when the production studio was last modified. For example, the time when the production studio was last started, stopped, or modified is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-01T05:08:45Z</para>
                /// </summary>
                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public string LastModified { get; set; }

                /// <summary>
                /// <para>The type of the production studio. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: playlist mode</description></item>
                /// <item><description>1: general mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NormType")]
                [Validation(Required=false)]
                public int? NormType { get; set; }

                /// <summary>
                /// <para>The time when the production studio was purchased.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-30 12:02:57.0</para>
                /// </summary>
                [NameInMap("PurchaseTime")]
                [Validation(Required=false)]
                public string PurchaseTime { get; set; }

                /// <summary>
                /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">Resource groups</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzw******</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The time when the production studio was started. This parameter is returned if the production studio is in the streaming status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-30 18:02:57.0</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the production studio. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: idle</description></item>
                /// <item><description>1: streaming</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCastersResponseBodyCasterListCasterTags Tags { get; set; }
                public class DescribeCastersResponseBodyCasterListCasterTags : TeaModel {
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public List<DescribeCastersResponseBodyCasterListCasterTagsTag> Tag { get; set; }
                    public class DescribeCastersResponseBodyCasterListCasterTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b9676b3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of production studios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
