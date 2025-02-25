// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCnameFlatteningRequest : TeaModel {
        /// <summary>
        /// <para>Flattening mode. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>flatten_all: Flatten all.</description></item>
        /// <item><description>flatten_at_root: Flatten only the root domain. The default is to flatten the root domain.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flatten_all</para>
        /// </summary>
        [NameInMap("FlattenMode")]
        [Validation(Required=false)]
        public string FlattenMode { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
