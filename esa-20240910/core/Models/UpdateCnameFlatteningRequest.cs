// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCnameFlatteningRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flatten_all</para>
        /// </summary>
        [NameInMap("FlattenMode")]
        [Validation(Required=false)]
        public string FlattenMode { get; set; }

        /// <summary>
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
