// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CountOralEvaluationStatisticsErrorRequest : TeaModel {
        /// <summary>
        /// <para>The request body for retrieving error statistics for the oral evaluation service.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public OralEvaluationStatisticsErrorCountRequest Body { get; set; }

    }

}
