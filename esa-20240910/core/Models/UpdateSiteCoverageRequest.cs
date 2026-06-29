// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteCoverageRequest : TeaModel {
        /// <summary>
        /// <para>The target acceleration region to change to. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: the Chinese mainland only.</description></item>
        /// <item><description><b>global</b>: global.</description></item>
        /// <item><description><b>overseas</b>: global (excluding the Chinese mainland).</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;If the value is set to domestic or global, the site corresponding to SiteId must have a valid ICP filing..</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>overseas</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to query the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
