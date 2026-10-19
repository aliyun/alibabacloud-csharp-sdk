// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInspectionScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 2 * * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>Specifies whether to start the scheduled task. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public long? Enabled { get; set; }

        /// <summary>
        /// <para>The specified inspection items. The following inspection items are supported:</para>
        /// <list type="bullet">
        /// <item><description>RESOURCE_USAGE</description></item>
        /// <item><description>BIGKEY</description></item>
        /// <item><description>HOTKEY</description></item>
        /// <item><description>PERFORMANCE_METRICS</description></item>
        /// <item><description>SLOWLOG</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HOTKEY</para>
        /// </summary>
        [NameInMap("InspectionItems")]
        [Validation(Required=false)]
        public string InspectionItems { get; set; }

        /// <summary>
        /// <para>1h</para>
        /// 
        /// <b>Example:</b>
        /// <para>1h</para>
        /// </summary>
        [NameInMap("InspectionWindow")]
        [Validation(Required=false)]
        public string InspectionWindow { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of associated instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The report language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the timed scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sch-4dfb08ddf9f84855bacca35axxx</para>
        /// </summary>
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// <para>The name of the timed scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-sche</para>
        /// </summary>
        [NameInMap("ScheduleName")]
        [Validation(Required=false)]
        public string ScheduleName { get; set; }

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
