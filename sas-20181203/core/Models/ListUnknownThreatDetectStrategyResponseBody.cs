// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of strategies.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUnknownThreatDetectStrategyResponseBodyData> Data { get; set; }
        public class ListUnknownThreatDetectStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asset selection identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNKNOWN_THREAT_DETECT_CONFIG_****</para>
            /// </summary>
            [NameInMap("AssetSelectionType")]
            [Validation(Required=false)]
            public string AssetSelectionType { get; set; }

            /// <summary>
            /// <para>The duration, in days, of the learning phase after model creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DurationDaysAfterInit")]
            [Validation(Required=false)]
            public int? DurationDaysAfterInit { get; set; }

            /// <summary>
            /// <para>The number of consecutive days without new process detections before the learning phase automatically ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DurationDaysAfterStop")]
            [Validation(Required=false)]
            public int? DurationDaysAfterStop { get; set; }

            /// <summary>
            /// <para>The strategy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public int? MachineCount { get; set; }

            /// <summary>
            /// <para>The strategy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The whitelist mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>hash</b>: process hash</para>
            /// </description></item>
            /// <item><description><para><b>path</b>: process path</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hash</para>
            /// </summary>
            [NameInMap("StudyMode")]
            [Validation(Required=false)]
            public string StudyMode { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListUnknownThreatDetectStrategyResponseBodyPageInfo PageInfo { get; set; }
        public class ListUnknownThreatDetectStrategyResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of matching entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>898F7AA7-CECD-5EC7-AF4D-664C601B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
