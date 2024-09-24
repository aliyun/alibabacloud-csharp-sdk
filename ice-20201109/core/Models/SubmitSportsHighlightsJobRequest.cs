// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSportsHighlightsJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
        ///   &quot;Count&quot;: 1,
        ///   &quot;Width&quot;: 1080,
        ///   &quot;Height&quot;: 1920
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
