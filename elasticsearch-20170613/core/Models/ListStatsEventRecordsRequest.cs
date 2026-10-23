// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListStatsEventRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the statistical window. The value is a UNIX timestamp in seconds. This parameter must be specified together with startTime and must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4600</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserOperator</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The event level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Info</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The start time of the statistical window. The value is a UNIX timestamp in seconds. This parameter must be specified together with endTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The event status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
