// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class RunPipelineRequest : TeaModel {
        /// <summary>
        /// <para>The start of the data processing window, in UNIX seconds. This parameter is required for SQL Pipeline and time window-based WorkItem Source. This parameter is optional for checkpoint-based WorkItem Source types such as Dataset and Logstore Pull.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The output control settings. SQL Pipeline supports overriding. WorkItem Pipeline uses the saved Sink configuration and must keep the default value.</para>
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public RunPipelineRequestOutput Output { get; set; }
        public class RunPipelineRequestOutput : TeaModel {
            /// <summary>
            /// <para>Specifies whether to write to the target Dataset. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public bool? Dataset { get; set; }

            /// <summary>
            /// <para>Specifies whether to return inline results in the response. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("inline")]
            [Validation(Required=false)]
            public bool? Inline { get; set; }

        }

        /// <summary>
        /// <para>The end of the data processing window, in UNIX seconds. This parameter must be provided together with fromTime and must be greater than fromTime. This parameter is optional for checkpoint-based WorkItem Source types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735747200</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
