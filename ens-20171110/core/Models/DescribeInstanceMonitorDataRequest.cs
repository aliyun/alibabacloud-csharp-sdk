// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. If the value of the seconds place is not 00, the start time is automatically set to the next minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-30T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can specify only one instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourInstance ID</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The precision of the monitoring data that you want to obtain. Valid values: 60, 300, 1200, 3600, and 14400. Default value: 60. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. If the value of the seconds place is not 00, the start time is automatically set to the next minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-29T23:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
