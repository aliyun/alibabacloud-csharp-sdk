// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class VerifyRankingSystemResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD16C2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
