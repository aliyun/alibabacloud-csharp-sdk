// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetEditingJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The information about editing tasks. The following fields are returned for each editing task:</para>
        /// <list type="bullet">
        /// <item><description><b>OutputVodId</b>: the ID of the output video-on-demand (VOD) file.</description></item>
        /// <item><description><b>TaskStatus</b>: the status of the editing task. Valid values: -1, 0, 1, 2, and 3. A value of -1 indicates that the editing task fails. A value of 0 indicates that the editing task is being initialized. A value of 1 indicates that editing is in progress. A value of 2 indicates that the output VOD file is being uploaded. A value of 3 indicates that the editing task is successful.</description></item>
        /// <item><description><b>StorageLocation</b>: the storage location in ApsaraVideo VOD.</description></item>
        /// <item><description><b>FileName</b>: the name of the file that is edited.</description></item>
        /// <item><description><b>ShowId</b>: the ID of the episode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;EditingTasksInfo&quot;: {     &quot;OutputVodId&quot;: &quot;3e34733b40b9a96ccf5c1ff6f69****&quot;,     &quot;TaskStatus&quot;: 1,     &quot;StorageInfo&quot;: {       &quot;StorageLocation&quot;: &quot;<em><b>bucket</b></em>&quot;,       &quot;FileName&quot;: &quot;EditFile****&quot;     },     &quot;ShowId&quot;: &quot;42200b81-b761-4c10-842a-a0726d97****&quot;   },</para>
        /// </summary>
        [NameInMap("EditingTasksInfo")]
        [Validation(Required=false)]
        public string EditingTasksInfo { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
