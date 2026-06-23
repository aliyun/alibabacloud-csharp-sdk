// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageBody : TeaModel {
        /// <summary>
        /// <para>The format of the parsing result.</para>
        /// <list type="bullet">
        /// <item><description>rawHtml: the HTML of the target website.</description></item>
        /// <item><description>html: the page content processed based on readabilityMode.</description></item>
        /// <item><description>markdown: the Markdown content converted from HTML.</description></item>
        /// <item><description>text: the text content extracted from HTML.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        /// <summary>
        /// <para>You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The maximum cache validity period. Unit: seconds. Default value: 1296000.</para>
        /// <list type="bullet">
        /// <item><description><para>If the cache duration is less than the value of maxAge, cached content is returned.</para>
        /// </description></item>
        /// <item><description><para>If the value of maxAge is 0, caching is not used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1296000</para>
        /// </summary>
        [NameInMap("maxAge")]
        [Validation(Required=false)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// <para>The URL read timeout period. The value of pageTimeout must be less than the value of timeout.</para>
        /// <para>Default value: 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("pageTimeout")]
        [Validation(Required=false)]
        public int? PageTimeout { get; set; }

        /// <summary>
        /// <para>The readability configuration for the parsing result.</para>
        /// </summary>
        [NameInMap("readability")]
        [Validation(Required=false)]
        public ReadPageBodyReadability Readability { get; set; }
        public class ReadPageBodyReadability : TeaModel {
            /// <summary>
            /// <para>Specifies whether to exclude all images.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllImages")]
            [Validation(Required=false)]
            public bool? ExcludeAllImages { get; set; }

            /// <summary>
            /// <para>Specifies whether to exclude all links.</para>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>none: does not remove any information. Default value: none.</para>
            /// </description></item>
            /// <item><description><para>normal: removes irrelevant information from the target page, such as headers, footers, and navigation elements, based on a proprietary algorithm.</para>
            /// </description></item>
            /// <item><description><para>article: extracts the main body content of the website based on a proprietary algorithm. This mode is suitable for blogs and news websites, but not for directory or navigation pages.</para>
            /// </description></item>
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
        /// <para>The target URL to parse. The value must start with http:// or https://.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://help.aliyun.com/document_detail/2837301.html?spm=a2c4g.11186623.help-menu-2837261.d_0_0_0.59ed3e95CppOt2&scm=20140722.H_2837301._.OR_help-T_cn~zh-V_1">https://help.aliyun.com/document_detail/2837301.html?spm=a2c4g.11186623.help-menu-2837261.d_0_0_0.59ed3e95CppOt2&amp;scm=20140722.H_2837301._.OR_help-T_cn~zh-V_1</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
