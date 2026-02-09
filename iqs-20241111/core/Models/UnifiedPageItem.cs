// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedPageItem : TeaModel {
        [NameInMap("correlationTag")]
        [Validation(Required=false)]
        public int? CorrelationTag { get; set; }

        [NameInMap("hostAuthorityScore")]
        [Validation(Required=false)]
        public double? HostAuthorityScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.china.com/zh_cn/img1905/2023/logo.png">https://www.china.com/zh_cn/img1905/2023/logo.png</a></para>
        /// </summary>
        [NameInMap("hostLogo")]
        [Validation(Required=false)]
        public string HostLogo { get; set; }

        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://hea.china.com/articles/20250427/202504271666343.html">https://hea.china.com/articles/20250427/202504271666343.html</a></para>
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        [NameInMap("mainText")]
        [Validation(Required=false)]
        public string MainText { get; set; }

        [NameInMap("markdownText")]
        [Validation(Required=false)]
        public string MarkdownText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-04-27T20:36:04+08:00</para>
        /// </summary>
        [NameInMap("publishedTime")]
        [Validation(Required=false)]
        public string PublishedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.7786493301391602</para>
        /// </summary>
        [NameInMap("rerankScore")]
        [Validation(Required=false)]
        public double? RerankScore { get; set; }

        [NameInMap("richMainBody")]
        [Validation(Required=false)]
        public string RichMainBody { get; set; }

        [NameInMap("snippet")]
        [Validation(Required=false)]
        public string Snippet { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("websiteAuthorityScore")]
        [Validation(Required=false)]
        public int? WebsiteAuthorityScore { get; set; }

    }

}
