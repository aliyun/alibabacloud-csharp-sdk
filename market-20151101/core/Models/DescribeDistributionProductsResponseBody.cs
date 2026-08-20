// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeDistributionProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of promotional products per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BD09171-MB74-18D8-890E-C70C067527BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The promotional product information.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DescribeDistributionProductsResponseBodyResults> Results { get; set; }
        public class DescribeDistributionProductsResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmap*****</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The first-level category name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API市场</para>
            /// </summary>
            [NameInMap("FirstCategoryName")]
            [Validation(Required=false)]
            public string FirstCategoryName { get; set; }

            /// <summary>
            /// <para>The URL of the product main image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>//photogallery.oss-cn-hangzhou.aliyuncs.com/photo/1744526877246715/09605255-87fd-44d1-8143-96ebc8019d46.jpeg</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>手机号码在网状态查询</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The price of the default product specification. For example, 100 indicates CNY 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            /// <summary>
            /// <para>The user rating of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// <para>The second-level category name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>生活服务</para>
            /// </summary>
            [NameInMap("SecondCategoryName")]
            [Validation(Required=false)]
            public string SecondCategoryName { get; set; }

            /// <summary>
            /// <para>The brief description of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>运营商号码状态查询】精准实时空号检测，手机号在网状态查询，返回正常、空号、通话中、在网但不可用、关机、呼叫转移、疑似关机、携号转网、号码错误、停机等多种状态。</para>
            /// </summary>
            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

            /// <summary>
            /// <para>The commission rebate ratio for the product. For example, 30 indicates 30%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SubmissionRadio")]
            [Validation(Required=false)]
            public string SubmissionRadio { get; set; }

            /// <summary>
            /// <para>The name of the promotion service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>深圳市****有限公司</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the promotion service provider (product supplier).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1911534921******</para>
            /// </summary>
            [NameInMap("SupplierUId")]
            [Validation(Required=false)]
            public string SupplierUId { get; set; }

            /// <summary>
            /// <para>The number of transactions for the product in the last 180 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>109</para>
            /// </summary>
            [NameInMap("TradeCount")]
            [Validation(Required=false)]
            public string TradeCount { get; set; }

            /// <summary>
            /// <para>The product type. Valid values:
            ///         APP: application
            ///         SERVICE: service
            ///         CHENGPIN_SITE: ready-made website
            ///         SITE_CUSTOM_SERVICE: custom website
            ///         SITE_PROMOTION_RUN: website promotion and operations
            ///         ENT_APP_SOFT: application software
            ///         CLOUD_SERVICE: cloud service
            ///         EIF: enterprise information
            ///         BASIC_TOOLS: basic tools
            ///         BASIC_SERVICES: basic services
            ///         JIANZHAN_XITONG: website building system
            ///         APP_COUPLES: application companion
            ///         MIRRORS_MARKET: image marketplace
            ///         MIRRORS_MARKET_BASIC_ENVIRONMENT: basic environment
            ///         MIRRORS_MARKET_APPLICATION_SOFTWARE: application software
            ///         MIRROR: image
            ///         DINGDING: DingTalk
            ///         DOWNLOAD: download
            ///         EXTENDED: unknown
            ///         API_SERVICE: API
            ///         ROS: resource orchestration
            ///         DOCKER: container
            ///         LICENSE: license key
            ///         SAAS_WUYING: application software - Wuying application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API类</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The number of buyer comments for the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("UserCommentCount")]
            [Validation(Required=false)]
            public string UserCommentCount { get; set; }

        }

        /// <summary>
        /// <para>The total number of promotional products that match the search conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
