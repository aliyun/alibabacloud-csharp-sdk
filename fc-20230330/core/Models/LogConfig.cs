// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class LogConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the collection of instance-level metrics. If you enable this feature, you can view core metrics, such as CPU utilization, memory usage, network conditions of instances, and the number of requests that an instance concurrently processes. Valid values: false: disables the collection of instance-level metrics. This is the default value. true: enables the collection of instance-level metrics.</para>
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
        /// <para>Specifies whether to enable request-level metrics. If you enable this feature, you can view the amount of time and memory consumed for a specific invocation of each function in the service. Valid values: false: disables request-level metrics. true: enables request-level metrics. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableRequestMetrics")]
        [Validation(Required=false)]
        public bool? EnableRequestMetrics { get; set; }

        /// <summary>
        /// <para>The log segmentation rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DefaultRegex</para>
        /// </summary>
        [NameInMap("logBeginRule")]
        [Validation(Required=false)]
        public string LogBeginRule { get; set; }

        /// <summary>
        /// <para>The name of the Logstore of Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the project in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
