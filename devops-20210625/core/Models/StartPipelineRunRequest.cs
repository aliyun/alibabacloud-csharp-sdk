// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class StartPipelineRunRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;branchModeBranchs&quot;:[         &quot;branch1&quot;,         &quot;branch2&quot;     ],     &quot;envs&quot;:{         &quot;k1&quot;:&quot;v1&quot;,         &quot;k2&quot;:&quot;v2&quot;,         &quot;k3&quot;:&quot;v3&quot;     },     &quot;runningBranchs&quot;:{         &quot;<a href="https://codeup.aliyun.com/60c1abb32c5969c370c5fcd0/Codeup-Demo.git%22:%22master1">https://codeup.aliyun.com/60c1abb32c5969c370c5fcd0/Codeup-Demo.git&quot;:&quot;master1</a>&quot;     },     &quot;runningTags&quot;:{         &quot;<a href="https://codeup.aliyun.com/60c1abb32c5969c370c5fcd0/Codeup-Demo.git%22:%221.0">https://codeup.aliyun.com/60c1abb32c5969c370c5fcd0/Codeup-Demo.git&quot;:&quot;1.0</a>&quot;     } }</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

    }

}
