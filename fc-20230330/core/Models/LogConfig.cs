// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class LogConfig : TeaModel {
        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableRequestMetrics")]
        [Validation(Required=false)]
        public bool? EnableRequestMetrics { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DefaultRegex</para>
        /// </summary>
        [NameInMap("logBeginRule")]
        [Validation(Required=false)]
        public string LogBeginRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
