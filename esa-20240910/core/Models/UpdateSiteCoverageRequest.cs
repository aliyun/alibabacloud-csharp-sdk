// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteCoverageRequest : TeaModel {
        /// <summary>
        /// <para>The target acceleration area to modify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>domestic</b>: Only the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: Global.</para>
        /// </description></item>
        /// <item><description><para><b>overseas</b>: Global (excluding the Chinese mainland).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The site ID. Get this by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> interface.</para>
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
