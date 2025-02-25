// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurgeCachesRequest : TeaModel {
        /// <summary>
        /// <para>Content to be refreshed.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public PurgeCachesRequestContent Content { get; set; }
        public class PurgeCachesRequestContent : TeaModel {
            /// <summary>
            /// <para>List of cachekeys to be refreshed, required when the type is cachekey.</para>
            /// </summary>
            [NameInMap("CacheKeys")]
            [Validation(Required=false)]
            public List<PurgeCachesRequestContentCacheKeys> CacheKeys { get; set; }
            public class PurgeCachesRequestContentCacheKeys : TeaModel {
                /// <summary>
                /// <para>When refreshing, specify the header information corresponding to the cache key. When the custom cache key feature switch is enabled, the cache key will be generated based on the specified header for refreshing.</para>
                /// <para><b>UserGeo: Country/Region</b></para>
                /// <list type="bullet">
                /// <item><description>Country/region codes follow the ISO 3166-2 standard.</description></item>
                /// </list>
                /// <para><b>UserDeviceType: Device Type, currently there are three enum values</b></para>
                /// <list type="bullet">
                /// <item><description>desktop</description></item>
                /// <item><description>tablet</description></item>
                /// <item><description>mobile</description></item>
                /// </list>
                /// <para><b>UserLanguage: Language</b></para>
                /// <list type="bullet">
                /// <item><description>Language codes follow the ISO 639-1 or BCP47 standards. For example, input \&quot;zh\&quot; to refresh content in Chinese.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>URL address to be refreshed.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://a.com/1.jpg?b=1">http://a.com/1.jpg?b=1</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>List of cachetags to be refreshed, required when the type is cachetag.</para>
            /// </summary>
            [NameInMap("CacheTags")]
            [Validation(Required=false)]
            public List<string> CacheTags { get; set; }

            /// <summary>
            /// <para>List of directories to be refreshed, required when the type is directory.</para>
            /// </summary>
            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<string> Directories { get; set; }

            /// <summary>
            /// <para>List of files to be refreshed, required when the type is file.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<object> Files { get; set; }

            /// <summary>
            /// <para>List of hostnames to be refreshed, required when the type is hostname.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>List of files with ignored parameters, required when the type is ignoreParams.</para>
            /// </summary>
            [NameInMap("IgnoreParams")]
            [Validation(Required=false)]
            public List<string> IgnoreParams { get; set; }

            /// <summary>
            /// <para>Flag for purging all content. Default is false, set to true when the type is purgeall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PurgeAll")]
            [Validation(Required=false)]
            public bool? PurgeAll { get; set; }

        }

        /// <summary>
        /// <para>Used for refreshing cached resources in edge computing, such as allowing the refresh of content cached using the CacheAPI interface of an edge function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EdgeComputePurge")]
        [Validation(Required=false)]
        public bool? EdgeComputePurge { get; set; }

        /// <summary>
        /// <para>Indicates whether to refresh all resources under the directory when the content from the origin and the source resource are inconsistent. The default is false.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Refreshes all resources under the specified directory.</description></item>
        /// <item><description><b>false</b>: Refreshes only the changed resources under the specified directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Applies to: Directory refresh, cachetag refresh, ignoreParams refresh, hostname refresh, and purge all cache of the site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The type of refresh task. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>file</b> (default): File refresh.</description></item>
        /// <item><description><b>cachekey</b>: Cachekey refresh.</description></item>
        /// <item><description><b>cachetag</b>: Cachetag refresh.</description></item>
        /// <item><description><b>directory</b>: Directory refresh.</description></item>
        /// <item><description><b>ignoreParams</b>: Ignore parameters refresh. Ignoring parameters means removing the ? and everything after it in the request URL. When performing an ignore parameters refresh, the user first submits the URL without parameters through the interface. The submitted URLs to be refreshed will then be matched against the cached resource URLs with the parameters removed. If the cached resource URL, after removing the parameters, matches the URL to be refreshed, the CDN node will refresh the cached resources.</description></item>
        /// <item><description><b>hostname</b>: Hostname refresh.</description></item>
        /// <item><description><b>purgeall</b>: Purge all cache under the site.</description></item>
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
