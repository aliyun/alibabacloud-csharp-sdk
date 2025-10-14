// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ds-jl67vixpe1scwysgyu3x。</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
