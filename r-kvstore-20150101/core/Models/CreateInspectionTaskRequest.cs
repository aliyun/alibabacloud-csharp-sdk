// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInspectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the inspection time range.</para>
        /// <para>The time is in the YYYY-MM-DDTHH:mm:ssZ format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-29T06:59:26Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The specified inspection items. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RESOURCE_USAGE</description></item>
        /// <item><description>BIGKEY</description></item>
        /// <item><description>HOTKEY</description></item>
        /// <item><description>PERFORMANCE_METRICS</description></item>
        /// <item><description>SLOWLOG</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE_USAGE</para>
        /// </summary>
        [NameInMap("InspectionItems")]
        [Validation(Required=false)]
        public string InspectionItems { get; set; }

        /// <summary>
        /// <para>The ID of the assistant instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of associated instance IDs.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The start time of the inspection time range.</para>
        /// <para>The time is in the YYYY-MM-DDTHH:mm:ssZ format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-29T05:59:26Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
