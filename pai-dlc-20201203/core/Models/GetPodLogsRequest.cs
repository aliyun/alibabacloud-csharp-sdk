// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodLogsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to download the log file. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
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
        /// <para>The maximum number of log entries. Default value: 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxLines")]
        [Validation(Required=false)]
        public int? MaxLines { get; set; }

        /// <summary>
        /// <para>The node UID. For more information about how to obtain a node UID, see <a href="https://help.aliyun.com/document_detail/459677.html">GetJob</a>.</para>
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
