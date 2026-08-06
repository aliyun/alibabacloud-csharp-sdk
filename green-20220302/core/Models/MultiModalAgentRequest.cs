// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalAgentRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the whiteboard application. To obtain the whiteboard application ID, see <a href="https://help.aliyun.com/document_detail/204234.html">CreateApp</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt_check_agent_01</para>
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// <para>The parameter set required by the moderation service. taskId specifies the taskId of the detection task to query. Only one taskId can be specified per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;Test text&quot;,&quot;dataId&quot;:&quot;img1234567&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
