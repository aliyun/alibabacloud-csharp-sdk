// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class RefreshObjectCacheByCacheTagRequest : TeaModel {
        /// <summary>
        /// <para>The tags of Cache. If multiple tags are returned, the tags are separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("CacheTag")]
        [Validation(Required=false)]
        public string CacheTag { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to purge all resources that you submit if the requested content is one of the resources that you submit to purge. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The nearest POP fetches all resources from the origin server, delivers them to the client, and updates the cache with the new version.</description></item>
        /// <item><description><b>false</b>: The nearest POP checks the Last-Modified parameter of the resource on the origin server. If the parameter value is the same as that of the cached resource, the POP serves the cached resource. If the parameter value is not the same as that of the cached resource, the POP fetches the latest version from the origin server, delivers it to the client, and updates the cache with the new version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
