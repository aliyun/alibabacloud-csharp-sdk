// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchGetExpressionFieldsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Expressions")]
        [Validation(Required=false)]
        public string ExpressionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
