// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalSkillGroupReportRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the historical data to retrieve. Specify a UNIX timestamp in milliseconds. This parameter is optional. Default value: the current time. The statistical time precision is in hours. The end time is rounded up to the nearest hour, and the interval is open. For example, if the start time is 11:12:20 and the end time is 11:45:50, the aligned time range is [11:00:00, 12:00:00), which means greater than or equal to 11:00:00 and less than 12:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1532707199000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The media type. Default value: Audio. Valid values: Audio, Chat, and Video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIDEO</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of skill group IDs to query. The value is a character string in the JSON array format, where each array element is a skill group ID. This parameter is optional. Default value: empty. An empty value indicates that all skill groups in the current paging are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;skillgroup1@ccc-test&quot;, &quot;skillgroup2@ccc-test2&quot;]</para>
        /// </summary>
        [NameInMap("SkillGroupIdList")]
        [Validation(Required=false)]
        public string SkillGroupIdList { get; set; }

        /// <summary>
        /// <para>The start time of the historical data to retrieve. Specify a UNIX timestamp in milliseconds. This parameter is optional. Default value: 00:00:00 on the current day. The earliest allowed time is 180 days before the current time. The statistical time precision is in hours. The start time is rounded down to the nearest hour, and the interval is closed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1532448000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to aggregate data by instance ID.</para>
        /// </summary>
        [NameInMap("SummarizeByInstanceId")]
        [Validation(Required=false)]
        public bool? SummarizeByInstanceId { get; set; }

    }

}
