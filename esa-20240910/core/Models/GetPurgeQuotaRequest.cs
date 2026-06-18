// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetPurgeQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the site. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
        /// <item><description><para><b>file</b> (default): File purge.</para>
        /// </description></item>
        /// <item><description><para><b>cachetag</b>: Cache tag purge.</para>
        /// </description></item>
        /// <item><description><para><b>directory</b>: Directory purge.</para>
        /// </description></item>
        /// <item><description><para><b>ignoreParams</b>: Purge by ignoring parameters.</para>
        /// </description></item>
        /// <item><description><para><b>hostname</b>: Hostname purge.</para>
        /// </description></item>
        /// <item><description><para><b>purgeall</b>: Purges all cached content for the site.</para>
        /// </description></item>
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
