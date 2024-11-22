// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteCoverageRequest : TeaModel {
        /// <summary>
        /// <para>The desired service location. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: the Chinese mainland</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
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
        /// <para>The website ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
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
