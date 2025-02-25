// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurgeCachesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Content to be refreshed.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

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
