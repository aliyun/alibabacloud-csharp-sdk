// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class SearchCredits : TeaModel {
        /// <summary>
        /// <para>The number of basic edition text search requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("genericTextSearch")]
        [Validation(Required=false)]
        public int? GenericTextSearch { get; set; }

        /// <summary>
        /// <para>The number of LiteAdvanced search requests.</para>
        /// </summary>
        [NameInMap("liteAdvancedTextSearch")]
        [Validation(Required=false)]
        public int? LiteAdvancedTextSearch { get; set; }

    }

}
