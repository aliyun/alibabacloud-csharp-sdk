// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurgeCachesRequest : TeaModel {
        /// <summary>
        /// <para>The content to purge.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public PurgeCachesRequestContent Content { get; set; }
        public class PurgeCachesRequestContent : TeaModel {
            [NameInMap("CacheKeys")]
            [Validation(Required=false)]
            public List<PurgeCachesRequestContentCacheKeys> CacheKeys { get; set; }
            public class PurgeCachesRequestContentCacheKeys : TeaModel {
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The cache tags that are used to purge the cache. This parameter is required if Type is set to cachetag.</para>
            /// </summary>
            [NameInMap("CacheTags")]
            [Validation(Required=false)]
            public List<string> CacheTags { get; set; }

            /// <summary>
            /// <para>The directories that are used to purge the cache. This parameter is required if Type is set to directory.</para>
            /// </summary>
            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<string> Directories { get; set; }

            /// <summary>
            /// <para>The files to purge. This parameter is required if Type is set to file.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<object> Files { get; set; }

            /// <summary>
            /// <para>The hostnames that are used to purge the cache. This parameter is required if Type is set to hostname.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>The file URLs with parameters ignored that are used to purge the cache. This parameter is required if Type is set to ignoreParams.</para>
            /// </summary>
            [NameInMap("IgnoreParams")]
            [Validation(Required=false)]
            public List<string> IgnoreParams { get; set; }

            /// <summary>
            /// <para>Specifies whether to purge all cache of the website. Default value: false. The value is true when Type is set to purgeall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PurgeAll")]
            [Validation(Required=false)]
            public bool? PurgeAll { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to purge cached resources for edge computing. For example, purge the resources cached by the CacheAPI operation of Edge Routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EdgeComputePurge")]
        [Validation(Required=false)]
        public bool? EdgeComputePurge { get; set; }

        /// <summary>
        /// <para>Specifies whether to purge resources in a directory if the resources requested are different from the resources on the origin server. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: purges all resources in the directory.</description></item>
        /// <item><description><b>false</b>: purges only changed resources in the directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This configuration takes effect for the following purge task types: directory, cachetag, ignoreParams, hostname, and purgeall.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The website ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The type of the purge task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>file</b> (default): purges the cache by file.</description></item>
        /// <item><description><b>cachetag</b>: purges the cache by cache tag.</description></item>
        /// <item><description><b>directory</b>: purges the cache by directory.</description></item>
        /// <item><description><b>ignoreParams</b>: purges the cache by URL with specific parameters ignored. This option ignores the question mark (?) and parameters after the question mark (?) in a request URL and purges the cache. After you call this operation with the request URL submitted, the system compares the submitted URL with the URL of the cached resource without specified parameters. If the URLs match, the POPs purge the cached resources.</description></item>
        /// <item><description><b>hostname</b>: purges the cache by hostname.</description></item>
        /// <item><description><b>purgeall</b>: purges all cache.</description></item>
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
