// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateInspectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the inspection task. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. By default, the time range of the task is the latest 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-30T02:10:48Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The inspection items. Separates multiple items with commas (,). If this parameter is empty or not specified, all inspection items are executed.</para>
        /// <h3><a href="#"></a>Valid values:</h3>
        /// <list type="bullet">
        /// <item><description>instance_info</description></item>
        /// <item><description>resource_usage</description></item>
        /// <item><description>connection_session_management</description></item>
        /// <item><description>performance_metrics</description></item>
        /// <item><description>slow_query_analysis</description></item>
        /// <item><description>error_log_analysis</description></item>
        /// <item><description>lock_wait_deadlock_analysis</description></item>
        /// <item><description>backup_recovery_analysis</description></item>
        /// <item><description>high_availability_disaster_recovery_analysis</description></item>
        /// <item><description>security_configuration_analysis</description></item>
        /// <item><description>storage_engine_analysis</description></item>
        /// <item><description>schema_object_analysis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance_info, resource_usage</para>
        /// </summary>
        [NameInMap("InspectionItems")]
        [Validation(Required=false)]
        public string InspectionItems { get; set; }

        /// <summary>
        /// <para>The instances covered by the task. Separates multiple instance IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze6mk259v322****,rm-2zef3b65430j0****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        /// <summary>
        /// <para>The start time of the inspection task. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. By default, the time range of the task is the latest 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-28T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
