// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructRefreshJobModel : TeaModel {
        /// <summary>
        /// <para>The end time of the refresh task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-15 10:12:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The materialized view name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_mv</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025103010xxxxxxx</para>
        /// </summary>
        [NameInMap("Processid")]
        [Validation(Required=false)]
        public string Processid { get; set; }

        /// <summary>
        /// <para>The refresh interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30s</para>
        /// </summary>
        [NameInMap("RefreshInterval")]
        [Validation(Required=false)]
        public string RefreshInterval { get; set; }

        /// <summary>
        /// <para>The refresh model.</para>
        /// <list type="bullet">
        /// <item><description>FAST</description></item>
        /// <item><description>COMPLETE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAST</para>
        /// </summary>
        [NameInMap("RefreshModel")]
        [Validation(Required=false)]
        public string RefreshModel { get; set; }

        /// <summary>
        /// <para>The resource group used for the refresh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The scheduled start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-15 10:11:00</para>
        /// </summary>
        [NameInMap("ScheduledStartTime")]
        [Validation(Required=false)]
        public string ScheduledStartTime { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The actual start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-15 10:11:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the queried refresh task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
