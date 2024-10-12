// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class FetchImageTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd327c3d5d5e44159cc716e23bfa530e_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1be065b-adc3-435e-bd01-1c18c5ed75d3</para>
        /// </summary>
        [NameInMap("ArticleTaskId")]
        [Validation(Required=false)]
        public string ArticleTaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;9d8c9185-3f75-4a20-aca1-c5bb53dd97b3&quot;]</para>
        /// </summary>
        [NameInMap("TaskIdList")]
        [Validation(Required=false)]
        public List<string> TaskIdList { get; set; }

    }

}
