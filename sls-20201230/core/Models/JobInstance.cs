// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class JobInstance : TeaModel {
        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784045339385</para>
        /// </summary>
        [NameInMap("beginTimeInMillis")]
        [Validation(Required=false)]
        public long? BeginTimeInMillis { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784045339385</para>
        /// </summary>
        [NameInMap("createTimeInMillis")]
        [Validation(Required=false)]
        public long? CreateTimeInMillis { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>加工作业</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>filter-get-request</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>401</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QueryErr(InvalidQuery): invalid metric keys provided: [metric_key1, metric_key2]</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>467b2b2cb7de2a9-656946cb235f3-52f6f88</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alimm_onebp_dtc_scs_prod_m_i_1561_p_x_1</para>
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The scheduled task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a4093d6cb4ed7e8bca3745b221af4c8</para>
        /// </summary>
        [NameInMap("jobScheduleId")]
        [Validation(Required=false)]
        public string JobScheduleId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The scheduled time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784045339385</para>
        /// </summary>
        [NameInMap("scheduleTimeInMillis")]
        [Validation(Required=false)]
        public long? ScheduleTimeInMillis { get; set; }

        /// <summary>
        /// <para>The current execution status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The schedule title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;pubNet\&quot;:0,\&quot;queryId\&quot;:\&quot;6A565F1DD71457AD541DEC77_76\&quot;,\&quot;shipBytes\&quot;:0,\&quot;shipLines\&quot;:0,\&quot;sqlCPUMillis\&quot;:0,\&quot;sqlCostMillis\&quot;:0,\&quot;sqlFromTime\&quot;:1784041200,\&quot;sqlProcessedBytes\&quot;:0,\&quot;sqlProcessedLines\&quot;:0,\&quot;sqlProgress\&quot;:\&quot;\&quot;,\&quot;sqlResultLines\&quot;:0,\&quot;sqlState\&quot;:\&quot;FAILED\&quot;,\&quot;sqlToTime\&quot;:1784044800,\&quot;userInfo\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784045339385</para>
        /// </summary>
        [NameInMap("updateTimeInMillis")]
        [Validation(Required=false)]
        public long? UpdateTimeInMillis { get; set; }

    }

}
