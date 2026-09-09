// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class StartMmsJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the migration job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public long? Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CA6292A-E301-5CD8-B4E2-AF060F99147B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
