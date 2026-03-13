// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SLSTriggerConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The invocation configurations. Simple Log Service passes the configurations into the function as part of the event. The configuration content must be a JSON string.</para>
        /// </summary>
        [NameInMap("functionParameter")]
        [Validation(Required=false)]
        public Dictionary<string, string> FunctionParameter { get; set; }

        /// <summary>
        /// <para>The interval at which the trigger reads logs, and the retry configuration upon errors.</para>
        /// </summary>
        [NameInMap("jobConfig")]
        [Validation(Required=false)]
        public JobConfig JobConfig { get; set; }

        /// <summary>
        /// <para>The log configurations of the trigger.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public SLSTriggerLogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The configurations of the trigger source.</para>
        /// </summary>
        [NameInMap("sourceConfig")]
        [Validation(Required=false)]
        public SourceConfig SourceConfig { get; set; }

    }

}
