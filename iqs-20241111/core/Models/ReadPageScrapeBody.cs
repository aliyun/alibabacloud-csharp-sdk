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

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("maxAge")]
        [Validation(Required=false)]
        public int? MaxAge { get; set; }

        [NameInMap("pageTimeout")]
        [Validation(Required=false)]
        public int? PageTimeout { get; set; }

        [NameInMap("readability")]
        [Validation(Required=false)]
        public ReadPageScrapeBodyReadability Readability { get; set; }
        public class ReadPageScrapeBodyReadability : TeaModel {
            [NameInMap("excludeAllImages")]
            [Validation(Required=false)]
            public bool? ExcludeAllImages { get; set; }

            [NameInMap("excludeAllLinks")]
            [Validation(Required=false)]
            public bool? ExcludeAllLinks { get; set; }

            [NameInMap("excludedTags")]
            [Validation(Required=false)]
            public List<string> ExcludedTags { get; set; }

            [NameInMap("readabilityMode")]
            [Validation(Required=false)]
            public string ReadabilityMode { get; set; }

        }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
