// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ResumeCopilotTurnStreamShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The conversation ID. This parameter is required for the second and subsequent turns in a multi-turn conversation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54b6c969-4b75-47be-9f43-71f88aeb****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The native run cursor mapping.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CursorByRun")]
        [Validation(Required=false)]
        public string CursorByRunShrink { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the data management center for threat analysis is located. You need to select the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The asset belongs to the Chinese mainland and China (Hong Kong).</description></item>
        /// <item><description>ap-southeast-1: The asset belongs to a region outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400e29b41d4a71644665544****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        /// <summary>
        /// <para>The primary key ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc18b894-19a3-45ee-8768-a59478e0****</para>
        /// </summary>
        [NameInMap("TurnId")]
        [Validation(Required=false)]
        public string TurnId { get; set; }

    }

}
