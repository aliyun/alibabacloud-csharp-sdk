// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckTaskHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the validation job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20001</para>
        /// </summary>
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// <para>Filters by validation result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No records.</description></item>
        /// <item><description>1: Passed.</description></item>
        /// <item><description>2: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("checkResult")]
        [Validation(Required=false)]
        public int? CheckResult { get; set; }

        /// <summary>
        /// <para>The end of the job creation time filter range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 10:00:00</para>
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// <para>The start of the job creation time filter range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 00:00:00</para>
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// <para>The end of the execution start time filter range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 12:00:00</para>
        /// </summary>
        [NameInMap("execEndTime")]
        [Validation(Required=false)]
        public string ExecEndTime { get; set; }

        /// <summary>
        /// <para>The start of the execution start time filter range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 10:00:00</para>
        /// </summary>
        [NameInMap("execStartTime")]
        [Validation(Required=false)]
        public string ExecStartTime { get; set; }

        /// <summary>
        /// <para>Filters by execution status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Pending.</description></item>
        /// <item><description>1: Running.</description></item>
        /// <item><description>2: Stopped.</description></item>
        /// <item><description>3: Failed.</description></item>
        /// <item><description>4: Completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("execStatus")]
        [Validation(Required=false)]
        public int? ExecStatus { get; set; }

        /// <summary>
        /// <para>The end of the execution end time filter range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 12:30:00</para>
        /// </summary>
        [NameInMap("finishEndTime")]
        [Validation(Required=false)]
        public string FinishEndTime { get; set; }

        /// <summary>
        /// <para>The start of the execution end time filter range. Format: YYYY-MM-DD HH:MM:SS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-16 10:30:00</para>
        /// </summary>
        [NameInMap("finishStartTime")]
        [Validation(Required=false)]
        public string FinishStartTime { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the data validation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
