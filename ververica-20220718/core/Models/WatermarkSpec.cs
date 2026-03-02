// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class WatermarkSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>time</para>
        /// </summary>
        [NameInMap("column")]
        [Validation(Required=false)]
        public string Column { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INTERVAL \&quot;5\&quot; SECOND</para>
        /// </summary>
        [NameInMap("watermarkExpression")]
        [Validation(Required=false)]
        public string WatermarkExpression { get; set; }

        [NameInMap("watermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
