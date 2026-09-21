// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCnameFlatteningRequest : TeaModel {
        /// <summary>
        /// <para>The flattening mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>flatten_all: flattens all records.</description></item>
        /// <item><description>flatten_at_root: flattens only the root domain. This is the default value.</description></item>
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
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
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
