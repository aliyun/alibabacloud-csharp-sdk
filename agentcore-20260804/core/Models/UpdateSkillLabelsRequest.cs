// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateSkillLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateSkillLabelsRequestBody Body { get; set; }
        public class UpdateSkillLabelsRequestBody : TeaModel {
            /// <summary>
            /// <para>The version label mapping JSON string.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;latest&quot;:&quot;0.0.2&quot;,&quot;stable&quot;:&quot;0.0.1&quot;}</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

        }

    }

}
