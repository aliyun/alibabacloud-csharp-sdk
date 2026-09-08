// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodLogsRequest : TeaModel {
        /// <summary>
        /// <para>Filters logs by specified containers. Separate multiple container names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pytorch,aimaster-worker</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public string Containers { get; set; }

        /// <summary>
        /// <para>Specifies whether to download the log file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): The log file is not downloaded.</description></item>
        /// <item><description>true: The log file is downloaded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DownloadToFile")]
        [Validation(Required=false)]
        public bool? DownloadToFile { get; set; }

        /// <summary>
        /// <para>The end time of the query. Default value: current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T17:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of log lines to return. Default value: 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxLines")]
        [Validation(Required=false)]
        public int? MaxLines { get; set; }

        /// <summary>
        /// <para>The node UID. For information about how to obtain the node UID, see <a href="https://help.aliyun.com/document_detail/459677.html">GetJob</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe846462-af2c-4521-bd6f-96787a57****</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        /// <summary>
        /// <para>The start time of the query. Default value: 7 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
