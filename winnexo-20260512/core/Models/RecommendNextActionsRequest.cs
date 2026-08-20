// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RecommendNextActionsRequest : TeaModel {
        /// <summary>
        /// <para>The extraction instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Only recommend next steps related to data analysis</para>
        /// </summary>
        [NameInMap("customPrompt")]
        [Validation(Required=false)]
        public string CustomPrompt { get; set; }

        /// <summary>
        /// <para>The output type: <c>conversation/skill/task</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>followUpOnly</para>
        /// </summary>
        [NameInMap("outputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>The number of recent messages used to assemble contextual information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("recentMessageCount")]
        [Validation(Required=false)]
        public long? RecentMessageCount { get; set; }

        /// <summary>
        /// <para>The session ID to filter by. If specified, returns all Active/Expired status information associated with this session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass this explicitly with --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
