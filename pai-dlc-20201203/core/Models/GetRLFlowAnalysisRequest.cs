// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLFlowAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query window in UTC RFC3339 format. Default value: now.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The start time of the query window in UTC RFC3339 format. Default value: EndTime-7d.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-04T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
