// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class GetClientRuleStrategyStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of proactive defense policies.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClientRuleStrategyStatisticsResponseBodyData Data { get; set; }
        public class GetClientRuleStrategyStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of custom rule policies for proactive defense.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CustomRuleCount")]
            [Validation(Required=false)]
            public int? CustomRuleCount { get; set; }

            /// <summary>
            /// <para>The number of system rule policies for proactive defense.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SystemRuleCount")]
            [Validation(Required=false)]
            public int? SystemRuleCount { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A157FA-F957-3A5A-A6B8-5BBB8ADB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
