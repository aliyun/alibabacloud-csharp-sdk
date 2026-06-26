// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class LogConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable instance-level metrics. When this feature is enabled, you can view core metrics for each instance, such as CPU usage, memory usage, network conditions, and the number of requests. The default value is \<c>false\\</c>, which disables instance-level metrics. Set the value to \<c>true\\</c> to enable them.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableInstanceMetrics")]
        [Validation(Required=false)]
        public bool? EnableInstanceMetrics { get; set; }

        [NameInMap("enableLlmMetrics")]
        [Validation(Required=false)]
        public bool? EnableLlmMetrics { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable request-level metrics. When this feature is enabled, you can view the time and memory consumed by each function invocation in the service. The default value is \<c>true\\</c>, which enables request-level metrics. Set the value to \<c>false\\</c> to disable them.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableRequestMetrics")]
        [Validation(Required=false)]
        public bool? EnableRequestMetrics { get; set; }

        /// <summary>
        /// <para>The rule for matching the first line of a log entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DefaultRegex</para>
        /// </summary>
        [NameInMap("logBeginRule")]
        [Validation(Required=false)]
        public string LogBeginRule { get; set; }

        /// <summary>
        /// <para>The name of the Logstore in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the Project in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
