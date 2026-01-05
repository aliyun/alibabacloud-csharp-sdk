// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetPortfolioResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the product portfolio.</para>
        /// </summary>
        [NameInMap("PortfolioDetail")]
        [Validation(Required=false)]
        public GetPortfolioResponseBodyPortfolioDetail PortfolioDetail { get; set; }
        public class GetPortfolioResponseBodyPortfolioDetail : TeaModel {
            /// <summary>
            /// <para>The time when the product portfolio was created.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:11:12Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the product portfolio.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:servicecatalog:cn-hangzhou:146611588617****:portfolio/port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioArn")]
            [Validation(Required=false)]
            public string PortfolioArn { get; set; }

            /// <summary>
            /// <para>The ID of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <para>The name of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-IT services</para>
            /// </summary>
            [NameInMap("PortfolioName")]
            [Validation(Required=false)]
            public string PortfolioName { get; set; }

            /// <summary>
            /// <para>The provider of the product portfolio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT team</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tag options associated with the service portfolio.</para>
        /// </summary>
        [NameInMap("TagOptions")]
        [Validation(Required=false)]
        public List<GetPortfolioResponseBodyTagOptions> TagOptions { get; set; }
        public class GetPortfolioResponseBodyTagOptions : TeaModel {
            /// <summary>
            /// <para>Indicates whether the tag option is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true (default)</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>The key of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>133413081827****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-bp1q65xd3j****</para>
            /// </summary>
            [NameInMap("TagOptionId")]
            [Validation(Required=false)]
            public string TagOptionId { get; set; }

            /// <summary>
            /// <para>The value of the tag option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
