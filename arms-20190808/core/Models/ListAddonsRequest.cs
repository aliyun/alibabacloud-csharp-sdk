// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAddonsRequest : TeaModel {
        /// <summary>
        /// Language,the default language is Chinese.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// Category filter.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// Whether to enable regular matching.
        /// </summary>
        [NameInMap("Regexp")]
        [Validation(Required=false)]
        public bool? Regexp { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// A query field can be queried by name or description.
        /// </summary>
        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

    }

}
