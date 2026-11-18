// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInspectionScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression for the periodic schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 2 * * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The specified inspection items. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RESOURCE_USAGE</description></item>
        /// <item><description>BIGKEY</description></item>
        /// <item><description>HOTKEY</description></item>
        /// <item><description>PERFORMANCE_METRICS</description></item>
        /// <item><description>SLOWLOG</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE_USAGE</para>
        /// </summary>
        [NameInMap("InspectionItems")]
        [Validation(Required=false)]
        public string InspectionItems { get; set; }

        /// <summary>
        /// <para>The time window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1h</para>
        /// </summary>
        [NameInMap("InspectionWindow")]
        [Validation(Required=false)]
        public string InspectionWindow { get; set; }

        /// <summary>
        /// <para>The ID of the assistant instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta-bp11iljddg37xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of associated instance IDs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Separate multiple instance IDs with commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The language of the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        /// <summary>
        /// <para>The name of the timed scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-sche</para>
        /// </summary>
        [NameInMap("ScheduleName")]
        [Validation(Required=false)]
        public string ScheduleName { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
