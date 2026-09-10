// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckReportStepRequest : TeaModel {
        /// <summary>
        /// <para>The verification result filter. Valid values:</para>
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
        /// <para>The job database ID (integer) that identifies a verification sub-job. This parameter differs in format from the UUID-format sub-job ID (string) used in the operation that queries step details by UUID. The two are not interchangeable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The step status filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: INIT.</description></item>
        /// <item><description>1: RUNNING.</description></item>
        /// <item><description>2: FINISHED.</description></item>
        /// <item><description>3: STOPPED.</description></item>
        /// <item><description>4: FAIL.</description></item>
        /// <item><description>6: READY.</description></item>
        /// <item><description>7: SKIPPED.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("jobStatus")]
        [Validation(Required=false)]
        public int? JobStatus { get; set; }

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

    }

}
