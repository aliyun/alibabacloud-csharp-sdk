// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeAutoShowListTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of scheduled tasks. The list contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>Status: The status of the task. A value of 0 indicates that the task is paused. A value of 1 indicates that the task is started.</para>
        /// </description></item>
        /// <item><description><para>LiveTemplate: The list of transcoding configurations.</para>
        /// </description></item>
        /// <item><description><para>TranscodeConfig: The resolution for transcoding the pulled stream.</para>
        /// </description></item>
        /// <item><description><para>CasterId: The ID of the production studio.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Status&quot;:0,&quot;TranscodeConfig&quot;:{&quot;CasterTemplate&quot;:&quot;lp_hd&quot;, &quot;LiveTemplate&quot;:[&quot;lhd&quot;,&quot;lsd&quot;]}, &quot;CasterId&quot;:&quot;cce04ef3-2226-4865-8704-f84b8375****&quot;}</para>
        /// </summary>
        [NameInMap("AutoShowListTasks")]
        [Validation(Required=false)]
        public string AutoShowListTasks { get; set; }

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
