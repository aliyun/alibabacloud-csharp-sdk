// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCacheConfigsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of Static Page Caching configurations.
        /// </summary>
        [NameInMap("DomainCacheConfigs")]
        [Validation(Required=false)]
        public List<DescribeWebCacheConfigsResponseBodyDomainCacheConfigs> DomainCacheConfigs { get; set; }
        public class DescribeWebCacheConfigsResponseBodyDomainCacheConfigs : TeaModel {
            /// <summary>
            /// An array that consists of custom caching rules.
            /// </summary>
            [NameInMap("CustomRules")]
            [Validation(Required=false)]
            public List<DescribeWebCacheConfigsResponseBodyDomainCacheConfigsCustomRules> CustomRules { get; set; }
            public class DescribeWebCacheConfigsResponseBodyDomainCacheConfigsCustomRules : TeaModel {
                /// <summary>
                /// The expiration time of the page cache. Unit: seconds.
                /// </summary>
                [NameInMap("CacheTtl")]
                [Validation(Required=false)]
                public long? CacheTtl { get; set; }

                /// <summary>
                /// The cache mode. Valid values:
                /// 
                /// *   **standard**: The standard cache mode is used.
                /// *   **aggressive**: The enhanced cache mode is used.
                /// *   **bypass**: No data is cached.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The name of the rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The path to the cached page.
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The status of the Static Page Caching policy. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// The cache mode. Valid values:
            /// 
            /// *   **standard**: The standard cache mode is used.
            /// *   **aggressive**: The enhanced cache mode is used.
            /// *   **bypass**: No data is cached.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
