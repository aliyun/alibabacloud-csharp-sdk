// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class RunPipelineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        [NameInMap("output")]
        [Validation(Required=false)]
        public RunPipelineRequestOutput Output { get; set; }
        public class RunPipelineRequestOutput : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public bool? Dataset { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("inline")]
            [Validation(Required=false)]
            public bool? Inline { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1735747200</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
