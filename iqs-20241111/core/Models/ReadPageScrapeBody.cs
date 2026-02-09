// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageScrapeBody : TeaModel {
        [NameInMap("formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1296000</para>
        /// </summary>
        [NameInMap("maxAge")]
        [Validation(Required=false)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15000</para>
        /// </summary>
        [NameInMap("pageTimeout")]
        [Validation(Required=false)]
        public int? PageTimeout { get; set; }

        [NameInMap("readability")]
        [Validation(Required=false)]
        public ReadPageScrapeBodyReadability Readability { get; set; }
        public class ReadPageScrapeBodyReadability : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllImages")]
            [Validation(Required=false)]
            public bool? ExcludeAllImages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("excludeAllLinks")]
            [Validation(Required=false)]
            public bool? ExcludeAllLinks { get; set; }

            [NameInMap("excludedTags")]
            [Validation(Required=false)]
            public List<string> ExcludedTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("readabilityMode")]
            [Validation(Required=false)]
            public string ReadabilityMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
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
