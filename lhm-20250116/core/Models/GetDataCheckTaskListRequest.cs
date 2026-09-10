// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckTaskListRequest : TeaModel {
        /// <summary>
        /// <para>The validation result filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no record.</description></item>
        /// <item><description>1: passed.</description></item>
        /// <item><description>2: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("checkResult")]
        [Validation(Required=false)]
        public int? CheckResult { get; set; }

        /// <summary>
        /// <para>The validation type filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: row count comparison.</description></item>
        /// <item><description>1: metric comparison.</description></item>
        /// <item><description>2: weak content comparison.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("checkType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The end of the creation time range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 10:00:00</para>
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// <para>The start of the creation time range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 00:00:00</para>
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// <para>The execution status filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: pending.</description></item>
        /// <item><description>1: running.</description></item>
        /// <item><description>2: stopped.</description></item>
        /// <item><description>3: failed.</description></item>
        /// <item><description>4: completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("execStatus")]
        [Validation(Required=false)]
        public int? ExecStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether scheduling is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disabled.</description></item>
        /// <item><description>1: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("isScheduled")]
        [Validation(Required=false)]
        public int? IsScheduled { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The task name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_check_task_demo</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The validation template name. Fuzzy match is supported. The server automatically converts the name into a list of template IDs for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Row Count Validation Template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The end of the update time range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-14 13:59:03</para>
        /// </summary>
        [NameInMap("updateEndTime")]
        [Validation(Required=false)]
        public string UpdateEndTime { get; set; }

        /// <summary>
        /// <para>The start of the update time range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-14 11:21:53</para>
        /// </summary>
        [NameInMap("updateStartTime")]
        [Validation(Required=false)]
        public string UpdateStartTime { get; set; }

    }

}
