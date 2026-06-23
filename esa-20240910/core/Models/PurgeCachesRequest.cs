// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurgeCachesRequest : TeaModel {
        /// <summary>
        /// <para>The refresh content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public PurgeCachesRequestContent Content { get; set; }
        public class PurgeCachesRequestContent : TeaModel {
            /// <summary>
            /// <para>The list of cache keys to refresh. This parameter is required when Type is set to cachekey.</para>
            /// </summary>
            [NameInMap("CacheKeys")]
            [Validation(Required=false)]
            public List<PurgeCachesRequestContentCacheKeys> CacheKeys { get; set; }
            public class PurgeCachesRequestContentCacheKeys : TeaModel {
                /// <summary>
                /// <para>The header information corresponding to the cache key specified during the refresh. When the custom cache key feature is enabled, the cache key is generated based on the specified headers for the refresh.</para>
                /// <para><b>UserGeo: country/region</b></para>
                /// <list type="bullet">
                /// <item><description>Country/region codes follow the ISO 3166-2 standard.</description></item>
                /// </list>
                /// <para><b>UserDeviceType: device type. Valid values:</b></para>
                /// <list type="bullet">
                /// <item><description><para>desktop</para>
                /// </description></item>
                /// <item><description><para>tablet</para>
                /// </description></item>
                /// <item><description><para>mobile</para>
                /// </description></item>
                /// </list>
                /// <para><b>UserLanguage: language</b></para>
                /// <list type="bullet">
                /// <item><description>Language codes follow the ISO 639-1 or BCP 47 standard. For example, set this to zh to refresh content in Chinese.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The URL to refresh.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://a.com/1.jpg?b=1">http://a.com/1.jpg?b=1</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The list of cache tags to refresh. This parameter is required when Type is set to cachetag.</para>
            /// </summary>
            [NameInMap("CacheTags")]
            [Validation(Required=false)]
            public List<string> CacheTags { get; set; }

            /// <summary>
            /// <para>The list of directories to refresh. This parameter is required when Type is set to directory.</para>
            /// </summary>
            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<string> Directories { get; set; }

            /// <summary>
            /// <para>The list of files to refresh. This parameter is required when Type is set to file.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<object> Files { get; set; }

            /// <summary>
            /// <para>The list of hostnames to refresh. This parameter is required when Type is set to hostname.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>The list of files with parameters ignored. This parameter is required when Type is set to ignoreParams.</para>
            /// </summary>
            [NameInMap("IgnoreParams")]
            [Validation(Required=false)]
            public List<string> IgnoreParams { get; set; }

            /// <summary>
            /// <para>Specifies whether to refresh the entire site. Default value: false. Set this parameter to true when Type is set to purgeall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PurgeAll")]
            [Validation(Required=false)]
            public bool? PurgeAll { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to refresh edge computing cached resources. For example, this allows you to refresh content cached by the Edge Routine CacheAPI API operation using the edge function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EdgeComputePurge")]
        [Validation(Required=false)]
        public bool? EdgeComputePurge { get; set; }

        /// <summary>
        /// <para>Specifies whether to refresh all resources under the corresponding directory when the back-to-origin content is inconsistent with the origin server resources. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Refreshes all resources under the corresponding directory.</description></item>
        /// <item><description><b>false</b>: Refreshes only the changed resources under the corresponding directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect for directory refresh, cache tag refresh, parameter-ignored refresh, hostname refresh, and full site refresh.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The type of the refresh node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>file</b> (default): file refresh.</description></item>
        /// <item><description><b>cachekey</b>: cache key refresh.</description></item>
        /// <item><description><b>cachetag</b>: cache label refresh.</description></item>
        /// <item><description><b>directory</b>: folder refresh.</description></item>
        /// <item><description><b>ignoreParams</b>: parameter-ignored refresh. This refers to removing the question mark (?) and all parameters after it from the request URL. When you commit a parameter-stripped URL through this API operation, the committed URL is matched against cached resource URLs after their parameters are also stripped. If a cached resource URL matches the committed URL after parameter stripping, the point of presence executes the refresh on the cached resource.</description></item>
        /// <item><description><b>hostname</b>: hostname refresh.</description></item>
        /// <item><description><b>purgeall</b>: refreshes all cached content under the site.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
