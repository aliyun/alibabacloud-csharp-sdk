// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnErUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routine1.test</para>
        /// </summary>
        [NameInMap("RoutineID")]
        [Validation(Required=false)]
        public string RoutineID { get; set; }

        /// <summary>
        /// <para>The specification of the routine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5ms</description></item>
        /// <item><description>50ms</description></item>
        /// <item><description>100ms</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50ms</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>Specifies how the results are grouped. If you set this parameter to routine, the returned results are grouped based on the routine ID. If you set this parameter to spec, the returned results are grouped based on the routine specification.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the returned results are not grouped.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>routine</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
