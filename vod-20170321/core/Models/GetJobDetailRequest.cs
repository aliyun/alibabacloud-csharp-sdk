// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetJobDetailRequest : TeaModel {
        /// <summary>
        /// <para>The task ID. Note: To query a transcoding task by TaskId, see <a href="https://www.alibabacloud.com/help/en/vod/developer-reference/api-vod-2017-03-21-gettranscodetask">GetTranscodeTask</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c9dff***************59d50a967f5</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>transcode</para>
        /// </description></item>
        /// <item><description><para>snapshot</para>
        /// </description></item>
        /// <item><description><para>ai</para>
        /// </description></item>
        /// <item><description><para>workflow</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transcode</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

    }

}
