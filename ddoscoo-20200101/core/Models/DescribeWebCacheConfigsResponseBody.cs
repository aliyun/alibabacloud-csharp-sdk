// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCacheConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of Static Page Caching configurations.</para>
        /// </summary>
        [NameInMap("DomainCacheConfigs")]
        [Validation(Required=false)]
        public List<DescribeWebCacheConfigsResponseBodyDomainCacheConfigs> DomainCacheConfigs { get; set; }
        public class DescribeWebCacheConfigsResponseBodyDomainCacheConfigs : TeaModel {
            /// <summary>
            /// <para>An array that consists of custom caching rules.</para>
            /// </summary>
            [NameInMap("CustomRules")]
            [Validation(Required=false)]
            public List<DescribeWebCacheConfigsResponseBodyDomainCacheConfigsCustomRules> CustomRules { get; set; }
            public class DescribeWebCacheConfigsResponseBodyDomainCacheConfigsCustomRules : TeaModel {
                /// <summary>
                /// <para>The expiration time of the page cache. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("CacheTtl")]
                [Validation(Required=false)]
                public long? CacheTtl { get; set; }

                /// <summary>
                /// <para>The cache mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>standard</b>: The standard cache mode is used.</description></item>
                /// <item><description><b>aggressive</b>: The enhanced cache mode is used.</description></item>
                /// <item><description><b>bypass</b>: No data is cached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The path to the cached page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/blog/</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The status of the Static Page Caching policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The cache mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>standard</b>: The standard cache mode is used.</description></item>
            /// <item><description><b>aggressive</b>: The enhanced cache mode is used.</description></item>
            /// <item><description><b>bypass</b>: No data is cached.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bypass</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6623EA1F-30FB-5BC8-BEC9-74D55F6F08F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
