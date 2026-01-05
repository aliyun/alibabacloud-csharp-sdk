// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProductsAsEndUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The products.</para>
        /// </summary>
        [NameInMap("ProductSummaries")]
        [Validation(Required=false)]
        public List<ListProductsAsEndUserResponseBodyProductSummaries> ProductSummaries { get; set; }
        public class ListProductsAsEndUserResponseBodyProductSummaries : TeaModel {
            /// <summary>
            /// <para>The time when the product was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:10:37Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the product.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the default launch option exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The default launch option exists. In this case, the PortfolioId parameter is not required when the product is launched or when the information about the product instance is updated.</description></item>
            /// <item><description>false: The default launch option does not exist. In this case, the PortfolioId parameter is required when the product is launched or when the information about the product instance is updated. For more information about the PortfolioId parameter, see <a href="~~ListLaunchOptions~~">ListLaunchOptions</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the product is added to only one product portfolio, the default launch option exists. If the product is added to multiple product portfolios, multiple launch options exist at the same time. However, no default launch options exist.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasDefaultLaunchOption")]
            [Validation(Required=false)]
            public bool? HasDefaultLaunchOption { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:servicecatalog:cn-hangzhou:146611588617****:product/prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductArn")]
            [Validation(Required=false)]
            public string ProductArn { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-Create an ECS instance</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The type of the product.</para>
            /// <para>The value is set to Ros, which indicates Resource Orchestration Service (ROS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ros</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The provider of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT team</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// <para>The type of the product template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RosTerraformTemplate: the Terraform template that is supported by ROS.</description></item>
            /// <item><description>RosStandardTemplate: the standard ROS template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RosTerraformTemplate</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
