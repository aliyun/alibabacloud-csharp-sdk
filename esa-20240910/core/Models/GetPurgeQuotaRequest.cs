// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetPurgeQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The refresh task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>file</b> (default): file refresh.</description></item>
        /// <item><description><b>cachetag</b>: cache tag refresh.</description></item>
        /// <item><description><b>directory</b>: directory refresh.</description></item>
        /// <item><description><b>ignoreParams</b>: ignore-parameters refresh.</description></item>
        /// <item><description><b>hostname</b>: hostname refresh.</description></item>
        /// <item><description><b>purgeall</b>: purge all cache under the site.</description></item>
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
