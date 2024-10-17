// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ByTimeScalingRuleSpec : TeaModel {
        /// <summary>
        /// <para>重复执行定时任务的结束时间戳。单位为毫秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639714800000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>启动时间戳。单位为毫秒。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639714634819</para>
        /// </summary>
        [NameInMap("LaunchTime")]
        [Validation(Required=false)]
        public long? LaunchTime { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>MON,FRI,SUN</para>
        /// </summary>
        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

    }

}
