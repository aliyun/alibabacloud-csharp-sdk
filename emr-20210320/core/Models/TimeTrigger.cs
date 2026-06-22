// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TimeTrigger : TeaModel {
        /// <summary>
        /// <para>The timestamp that specifies the end time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639714800000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The time period during which a scheduled task can be retried after it fails. Unit: seconds. Valid values: 0 to 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("LaunchExpirationTime")]
        [Validation(Required=false)]
        public int? LaunchExpirationTime { get; set; }

        /// <summary>
        /// <para>The execution time of the scaling rule. This parameter is required. The value is a string in the HH:MM format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17:30</para>
        /// </summary>
        [NameInMap("LaunchTime")]
        [Validation(Required=false)]
        public string LaunchTime { get; set; }

        /// <summary>
        /// <para>The frequency of executing the specified rule whose trigger mode is scaling by time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY</description></item>
        /// <item><description>WEEKLY</description></item>
        /// <item><description>MONTHLY</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WEEKLY</para>
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// <para>The number of recurrences of the scheduled task. The value of this parameter depends on the value of RecurrenceType.</para>
        /// <list type="bullet">
        /// <item><description>If the RecurrenceType parameter is set to DAILY, you can specify only one value for this parameter. Valid values: 1 to 31.</description></item>
        /// <item><description>If the RecurrenceType parameter is set to WEEKLY, you can specify multiple values for this parameter and separate them with commas (,). The values MON, TUE, WED, THU, FRI, SAT, and SUN indicate the days from Monday to Sunday. For example, the value MON,FRI,SUN stands for Monday, Friday, and Sunday.</description></item>
        /// <item><description>If the RecurrenceType parameter is set to MONTHLY, the value of this parameter is in the A-B or A,B format. The values of A and B are both in the range of 1 to 31. If you use the A-B format, the value of B must be greater than the value of A.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MON,FRI,SUN</para>
        /// </summary>
        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

        /// <summary>
        /// <para>The timestamp that specifies the start time. This parameter is required. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639714800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
