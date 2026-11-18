// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageScrapeBody : TeaModel {
        /// <summary>
        /// <para>The formats of the parsed result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>rawHtml: The HTML of the target site.</description></item>
        /// <item><description>html: The page content processed based on the readabilityMode.</description></item>
        /// <item><description>markdown: The Markdown content converted from the HTML.</description></item>
        /// <item><description>text: The text content in the HTML.</description></item>
        /// <item><description>screenshot: The screenshot of the target site.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        /// <summary>
        /// <para>This parameter is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The maximum cache duration, in seconds.</para>
        /// <list type="bullet">
        /// <item><description>If the cache duration is less than the maxAge value, the cached content is returned.</description></item>
        /// <item><description>If the maxAge value is set to 0, the cache is not used.</description></item>
        /// </list>
        /// <para>Default value: 1296000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1296000</para>
        /// </summary>
        [NameInMap("maxAge")]
        [Validation(Required=false)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// <para>The timeout period for waiting for the resources of the target site to fully load. The pageTimeout value must be less than the timeout value.</para>
        /// <para>Default value: 15000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15000</para>
        /// </summary>
        [NameInMap("pageTimeout")]
        [Validation(Required=false)]
        public int? PageTimeout { get; set; }

        /// <summary>
        /// <para>The readability configuration of the parsed result.</para>
        /// </summary>
        [NameInMap("readability")]
        [Validation(Required=false)]
        public ReadPageScrapeBodyReadability Readability { get; set; }
        public class ReadPageScrapeBodyReadability : TeaModel {
            /// <summary>
            /// <para>Specifies whether to remove all images.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllImages")]
            [Validation(Required=false)]
            public bool? ExcludeAllImages { get; set; }

            /// <summary>
            /// <para>Specifies whether to remove all links.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllLinks")]
            [Validation(Required=false)]
            public bool? ExcludeAllLinks { get; set; }

            /// <summary>
            /// <para>The tags to exclude.</para>
            /// </summary>
            [NameInMap("excludedTags")]
            [Validation(Required=false)]
            public List<string> ExcludedTags { get; set; }

            /// <summary>
            /// <para>The readability mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>none: Does not remove any information. This is the default value.</description></item>
            /// <item><description>normal: Removes irrelevant information from the target page, such as headers, footers, and navigation elements, based on a proprietary algorithm.</description></item>
            /// <item><description>article: Extracts the main body content of the site based on a proprietary algorithm. This mode is suitable for blogs and news sites, but not for directory or navigation pages.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("readabilityMode")]
            [Validation(Required=false)]
            public string ReadabilityMode { get; set; }

        }

        /// <summary>
        /// <para>The end-to-end processing timeout period, in milliseconds.</para>
        /// <para>Valid values: 0 to 180000.</para>
        /// <para>Default value: 60000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The target URL to parse. It must start with http:// or https://.</para>
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
