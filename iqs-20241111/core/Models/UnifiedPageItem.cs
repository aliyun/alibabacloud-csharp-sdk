// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedPageItem : TeaModel {
        [NameInMap("hostLogo")]
        [Validation(Required=false)]
        public string HostLogo { get; set; }

        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        [NameInMap("mainText")]
        [Validation(Required=false)]
        public string MainText { get; set; }

        [NameInMap("markdownText")]
        [Validation(Required=false)]
        public string MarkdownText { get; set; }

        [NameInMap("publishedTime")]
        [Validation(Required=false)]
        public string PublishedTime { get; set; }

        [NameInMap("rerankScore")]
        [Validation(Required=false)]
        public double? RerankScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-04-07T10:15:30.123+08:00</para>
        /// </summary>
        [NameInMap("snippet")]
        [Validation(Required=false)]
        public string Snippet { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
