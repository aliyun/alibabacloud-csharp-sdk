// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TimeTrigger : TeaModel {
        /// <summary>
        /// <para>结束时间戳。单位为毫秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639714800000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>定时任务触发操作失败后，在此时间内重试。单位为秒，取值范围：0~3600。</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("LaunchExpirationTime")]
        [Validation(Required=false)]
        public int? LaunchExpirationTime { get; set; }

        /// <summary>
        /// <para>启动时间。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LaunchTime")]
        [Validation(Required=false)]
        public string LaunchTime { get; set; }

        /// <summary>
        /// <para>指定时间规则的执行类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEEKLY</para>
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// <para>重复执行定时任务的数值。具体取值取决于 recurrenceType 设置。</para>
        /// <list type="bullet">
        /// <item><description>recurrenceType 取 MINUTELY 时，只能填一个数值，取值范围：1~1440。</description></item>
        /// <item><description>recurrenceType 取 HOURLY 时，只能填一个数值，取值范围：1~24。</description></item>
        /// <item><description>recurrenceType 取 DAILY 时，只能填一个数值，取值范围：1~31。</description></item>
        /// <item><description>recurrenceType 取 WEEKLY 时，可以填入多个值，填多个值时使用英文逗号（,）分隔。周一到周天分别用MON，TUE，WED，THU，FRI，SAT，SUN代替。 比如 MON,FRI,SUN 代表周一、周五、周天。</description></item>
        /// <item><description>recurrenceType 取 MONTHLY 时，格式为A-B或者A,B。A、B的取值范围为1~31，如果使用A-B时B必须大于A。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MON,FRI,SUN</para>
        /// </summary>
        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

        /// <summary>
        /// <para>开始时间戳。单位为毫秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639714800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
