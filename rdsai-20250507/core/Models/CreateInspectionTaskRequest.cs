// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateInspectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the inspection range. Format: YYYY-MM-DDTHH:mm:ssZ (UTC). Default value: the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-30T02:10:48Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of inspection items. Separate multiple values with commas (,). If this parameter is left empty or not specified, all inspection items are executed.</para>
        /// <h3>Available inspection items:</h3>
        /// <list type="bullet">
        /// <item><description>instance_info (instance information)</description></item>
        /// <item><description>resource_usage (resource usage)</description></item>
        /// <item><description>connection_session_management (connection and session management)</description></item>
        /// <item><description>performance_metrics (performance metrics)</description></item>
        /// <item><description>slow_query_analysis (slow query analysis)</description></item>
        /// <item><description>error_log_analysis (error log analysis)</description></item>
        /// <item><description>lock_wait_deadlock_analysis (lock wait and deadlock analysis)</description></item>
        /// <item><description>backup_recovery_analysis (backup and recovery analysis)</description></item>
        /// <item><description>high_availability_disaster_recovery_analysis (high availability and disaster recovery inspection)</description></item>
        /// <item><description>security_configuration_analysis (security configuration inspection)</description></item>
        /// <item><description>storage_engine_analysis (storage engine inspection)</description></item>
        /// <item><description>schema_object_analysis (schema and object inspection)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance_info, resource_usage</para>
        /// </summary>
        [NameInMap("InspectionItems")]
        [Validation(Required=false)]
        public string InspectionItems { get; set; }

        /// <summary>
        /// <para>The list of associated instance IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze6mk259v322****,rm-2zef3b65430j0****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        [NameInMap("ReportRegionId")]
        [Validation(Required=false)]
        public string ReportRegionId { get; set; }

        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The start time of the inspection range. Format: YYYY-MM-DDTHH:mm:ssZ (UTC). Default value: 24 hours before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-28T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
