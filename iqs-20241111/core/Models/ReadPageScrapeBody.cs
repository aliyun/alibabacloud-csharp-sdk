// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageScrapeBody : TeaModel {
        /// <summary>
        /// <para>The format of the parsing result.</para>
        /// <list type="bullet">
        /// <item><description>rawHtml: the HTML of the target site.</description></item>
        /// <item><description>html: the page content processed based on readabilityMode.</description></item>
        /// <item><description>markdown: the Markdown content converted from the HTML.</description></item>
        /// <item><description>text: the text content extracted from the HTML.</description></item>
        /// <item><description>screenshot: a screenshot of the target site.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        /// <summary>
        /// <para>This parameter does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The maximum cache validity period. Unit: seconds. Default value: 1296000.</para>
        /// <ol>
        /// <item><description>If the cache duration is less than the value of maxAge, cached content is returned.</description></item>
        /// <item><description>If maxAge is set to 0, caching is not used.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>1296000</para>
        /// </summary>
        [NameInMap("maxAge")]
        [Validation(Required=false)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// <para>The timeout period for waiting for the target site resources to fully load. The value of pageTimeout must be less than the value of timeout.</para>
        /// <para>Default value: 15000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15000</para>
        /// </summary>
        [NameInMap("pageTimeout")]
        [Validation(Required=false)]
        public int? PageTimeout { get; set; }

        /// <summary>
        /// <para>The readability configuration for the parsing result.</para>
        /// </summary>
        [NameInMap("readability")]
        [Validation(Required=false)]
        public ReadPageScrapeBodyReadability Readability { get; set; }
        public class ReadPageScrapeBodyReadability : TeaModel {
            /// <summary>
            /// <para>是否剔除所有图片</para>
            /// <para>默认值：false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllImages")]
            [Validation(Required=false)]
            public bool? ExcludeAllImages { get; set; }

            /// <summary>
            /// <para>是否剔除所有链接</para>
            /// <para>默认值：false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllLinks")]
            [Validation(Required=false)]
            public bool? ExcludeAllLinks { get; set; }

            /// <summary>
            /// <para>指定排除的标签</para>
            /// </summary>
            [NameInMap("excludedTags")]
            [Validation(Required=false)]
            public List<string> ExcludedTags { get; set; }

            /// <summary>
            /// <para>none：不删除信息，默认为 none</para>
            /// <para>normal: 基于自研算法，剔除目标页面无关信息（页头/页脚，导航等）</para>
            /// <para>article: 基于自研算法，获取站点主要正文内容(适用于博客、新闻站点，不适用于目录页、导航页)</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("readabilityMode")]
            [Validation(Required=false)]
            public string ReadabilityMode { get; set; }

        }

        /// <summary>
        /// <para>The end-to-end processing timeout period. Unit: ms.</para>
        /// <para>Valid values: [0, 180000].</para>
        /// <para>Default value: 60000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The target URL to parse. The URL must start with http:// or https://.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
