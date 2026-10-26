// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetCalculationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The AB metric ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ABMetricId")]
        [Validation(Required=false)]
        public string ABMetricId { get; set; }

        /// <summary>
        /// <para>The AB metric name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv</para>
        /// </summary>
        [NameInMap("ABMetricName")]
        [Validation(Required=false)]
        public string ABMetricName { get; set; }

        /// <summary>
        /// <para>The business date. The value is in YYYY-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// <para>The task configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The time when the task ran. The value is in ISO 8601 format and includes a time zone offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtRanTime")]
        [Validation(Required=false)]
        public string GmtRanTime { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("JobMessage")]
        [Validation(Required=false)]
        public List<string> JobMessage { get; set; }

        /// <summary>
        /// <para>The task source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CronOffline: a scheduled offline task.</description></item>
        /// <item><description>DataRerun: a data rerun task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CronOffline</para>
        /// </summary>
        [NameInMap("JobSource")]
        [Validation(Required=false)]
        public string JobSource { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D59453C-48AA-5FC5-8848-2D373BD1A17F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the compute task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success: The task succeeded.</description></item>
        /// <item><description>Failure: The task failed.</description></item>
        /// <item><description>Initializing: The task is being initialized.</description></item>
        /// <item><description>Running: The task is running.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
