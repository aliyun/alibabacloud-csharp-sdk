// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end time (UTC) of the time range for querying events. The default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T18:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of events that can be returned. Default value: 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxEventsNum")]
        [Validation(Required=false)]
        public int? MaxEventsNum { get; set; }

        /// <summary>
        /// <para>The start time (UTC) of the time range for querying events. The default value is 7 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
