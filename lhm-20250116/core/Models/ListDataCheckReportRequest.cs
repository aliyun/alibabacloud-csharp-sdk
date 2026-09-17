// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckReportRequest : TeaModel {
        /// <summary>
        /// <para>The validation job (batch) ID.</para>
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
        /// <para>Filters by job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: INIT (pending).</description></item>
        /// <item><description>1: RUNNING (running).</description></item>
        /// <item><description>2: FINISHED (completed).</description></item>
        /// <item><description>3: STOPPED (stopped).</description></item>
        /// <item><description>4: FAIL (failed).</description></item>
        /// <item><description>6: READY (ready).</description></item>
        /// <item><description>7: SKIPPED (skipped).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("jobStatus")]
        [Validation(Required=false)]
        public int? JobStatus { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The table name to filter by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dim_func_with_diff_area_data_d</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
