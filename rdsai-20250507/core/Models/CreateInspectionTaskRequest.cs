// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateInspectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The end of the inspection time range. The time must be in UTC and formatted as YYYY-MM-DDTHH:mm:ssZ. If StartTime and EndTime are not specified, the inspection covers the last 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-30T02:10:48Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The inspection items to run, separated by commas. If this parameter is omitted, all inspection items are run.</para>
        /// <h3>Inspection items</h3>
        /// <list type="bullet">
        /// <item><description><para><c>instance_info</c> (instance information)</para>
        /// </description></item>
        /// <item><description><para><c>resource_usage</c> (resource usage)</para>
        /// </description></item>
        /// <item><description><para><c>connection_session_management</c> (connection and session management)</para>
        /// </description></item>
        /// <item><description><para><c>performance_metrics</c> (performance metrics)</para>
        /// </description></item>
        /// <item><description><para><c>slow_query_analysis</c> (slow query analysis)</para>
        /// </description></item>
        /// <item><description><para><c>error_log_analysis</c> (error log analysis)</para>
        /// </description></item>
        /// <item><description><para><c>lock_wait_deadlock_analysis</c> (lock wait and deadlock analysis)</para>
        /// </description></item>
        /// <item><description><para><c>backup_recovery_analysis</c> (backup and recovery analysis)</para>
        /// </description></item>
        /// <item><description><para><c>high_availability_disaster_recovery_analysis</c> (high availability and disaster recovery inspection)</para>
        /// </description></item>
        /// <item><description><para><c>security_configuration_analysis</c> (security configuration inspection)</para>
        /// </description></item>
        /// <item><description><para><c>storage_engine_analysis</c> (storage engine inspection)</para>
        /// </description></item>
        /// <item><description><para><c>schema_object_analysis</c> (schema and object inspection)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance_info, resource_usage</para>
        /// </summary>
        [NameInMap("InspectionItems")]
        [Validation(Required=false)]
        public string InspectionItems { get; set; }

        /// <summary>
        /// <para>The IDs of the instances to inspect. Separate multiple instance IDs with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze6mk259v322****,rm-2zef3b65430j0****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The language of the inspection report. Valid values are zh-CN (Simplified Chinese) and en-US (English). The default value is en-US.</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        [NameInMap("ReportRegionId")]
        [Validation(Required=false)]
        public string ReportRegionId { get; set; }

        /// <summary>
        /// <para>The format of the inspection report. Valid values are pdf and json. The default value is pdf.</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The beginning of the inspection time range. The time must be in UTC and formatted as YYYY-MM-DDTHH:mm:ssZ. If StartTime and EndTime are not specified, the inspection covers the last 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-28T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
