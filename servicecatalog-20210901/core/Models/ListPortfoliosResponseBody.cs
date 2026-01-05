// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListPortfoliosResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PortfolioDetails")]
        [Validation(Required=false)]
        public List<ListPortfoliosResponseBodyPortfolioDetails> PortfolioDetails { get; set; }
        public class ListPortfoliosResponseBodyPortfolioDetails : TeaModel {
            /// <summary>
            /// <para>代表创建时间的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:11:12Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>产品组合描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:servicecatalog:cn-hangzhou:146611588617****:portfolio/port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioArn")]
            [Validation(Required=false)]
            public string PortfolioArn { get; set; }

            /// <summary>
            /// <para>代表资源一级ID的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <para>代表资源名称的资源属性字段</para>
            /// </summary>
            [NameInMap("PortfolioName")]
            [Validation(Required=false)]
            public string PortfolioName { get; set; }

            /// <summary>
            /// <para>产品组合提供方</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
