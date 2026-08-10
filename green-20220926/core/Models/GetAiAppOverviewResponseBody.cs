// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetAiAppOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of agents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AppTotal")]
        [Validation(Required=false)]
        public long? AppTotal { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The distribution of risk events by level.</para>
        /// </summary>
        [NameInMap("RiskEventLevelDistribution")]
        [Validation(Required=false)]
        public Dictionary<string, object> RiskEventLevelDistribution { get; set; }

        /// <summary>
        /// <para>The total number of resolved risk events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RiskEventResolvedTotal")]
        [Validation(Required=false)]
        public long? RiskEventResolvedTotal { get; set; }

        /// <summary>
        /// <para>The total number of risk events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RiskEventTotal")]
        [Validation(Required=false)]
        public long? RiskEventTotal { get; set; }

        /// <summary>
        /// <para>The total number of unhandled risk events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RiskEventUnhandledTotal")]
        [Validation(Required=false)]
        public long? RiskEventUnhandledTotal { get; set; }

    }

}
