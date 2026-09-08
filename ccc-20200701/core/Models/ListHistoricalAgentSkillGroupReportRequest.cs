// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalAgentSkillGroupReportRequest : TeaModel {
        /// <summary>
        /// <para>List of agent IDs. The list size is 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;agent1@ccc-test&quot;, &quot;agent2@ccc-test&quot;]</para>
        /// </summary>
        [NameInMap("AgentIdList")]
        [Validation(Required=false)]
        public string AgentIdList { get; set; }

        /// <summary>
        /// <para>End time for historical data retrieval. Format is UNIX timestamp in milliseconds. Optional. Defaults to the current time. The statistical time granularity is hourly, rounded up to the nearest hour, in an open interval. For example, if the start time is 11:12:20 and the end time is 11:45:50, the aligned request parameter time range is [11:00:00, 12:00:00), meaning greater than or equal to 11:00 and less than 12:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620273600000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Media type. Defaults to Audio. Other optional parameters include Chat and Video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIDEO</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>Page number. Valid values are 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size. Valid values are 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of skill group IDs. The list size is 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       &quot;skg1@ccc-test&quot;,
        ///       &quot;skg2@ccc-test&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("SkillGroupIdList")]
        [Validation(Required=false)]
        public string SkillGroupIdList { get; set; }

        /// <summary>
        /// <para>Start timestamp. Defaults to 00:00 on the current day. The statistical time granularity is hourly, rounded down to the nearest hour, in a closed interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634140800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
