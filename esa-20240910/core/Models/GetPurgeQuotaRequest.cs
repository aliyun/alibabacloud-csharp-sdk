// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetPurgeQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The website ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
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
        /// <item><description><b>ignoreParams</b>: purges the cache by URL with specific parameters ignored.</description></item>
        /// <item><description><b>hostname</b>: purges the cache by hostname.</description></item>
        /// <item><description><b>purgeall</b>: purges all cache.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
