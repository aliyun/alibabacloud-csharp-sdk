// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveBaseStrategyPeriodRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe51eca2-a904-4b4d-b3ff-31be334b9500</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyWeekdays")]
        [Validation(Required=false)]
        public bool? OnlyWeekdays { get; set; }

        [NameInMap("OnlyWorkdays")]
        [Validation(Required=false)]
        public bool? OnlyWorkdays { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StrategyLevel")]
        [Validation(Required=false)]
        public int? StrategyLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("WorkingTime")]
        [Validation(Required=false)]
        public List<string> WorkingTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;beginTime\&quot;:\&quot;09:00:00\&quot;,\&quot;beginTimeMillis\&quot;:324000000000,\&quot;endTime\&quot;:\&quot;21:00:00\&quot;,\&quot;endTimeMillis\&quot;:756000000000}]</para>
        /// </summary>
        [NameInMap("WorkingTimeFramesJson")]
        [Validation(Required=false)]
        public string WorkingTimeFramesJson { get; set; }

    }

}
