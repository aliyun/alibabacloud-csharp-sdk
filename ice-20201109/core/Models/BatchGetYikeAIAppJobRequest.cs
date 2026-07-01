// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetYikeAIAppJobRequest : TeaModel {
        /// <summary>
        /// <para>A list of job IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cec2c13da767c090,ca3d3c9737f04586</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

    }

}
