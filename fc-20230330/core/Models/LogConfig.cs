// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class LogConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable instance-level metrics. After you enable this feature, you can view core metrics such as CPU usage, memory usage, network status, and request count at the instance level. Valid values: false: disables instance-level metrics. This is the default value. true: enables instance-level metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableInstanceMetrics")]
        [Validation(Required=false)]
        public bool? EnableInstanceMetrics { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable LLM metrics. After you enable this feature, you can view LLM metrics. We recommend that you enable this feature only for LLM inference services. Valid values: false: disables LLM metrics. This is the default value. true: enables LLM metrics.</para>
        /// </summary>
        [NameInMap("enableLlmMetrics")]
        [Validation(Required=false)]
        public bool? EnableLlmMetrics { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable request-level metrics. After you enable this feature, you can view the time and memory consumed by each invocation of all functions in the service. Valid values: false: disables request-level metrics. true: enables request-level metrics. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableRequestMetrics")]
        [Validation(Required=false)]
        public bool? EnableRequestMetrics { get; set; }

        /// <summary>
        /// <para>The log line beginning matching rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DefaultRegex</para>
        /// </summary>
        [NameInMap("logBeginRule")]
        [Validation(Required=false)]
        public string LogBeginRule { get; set; }

        /// <summary>
        /// <para>The Logstore name in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The project name in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
