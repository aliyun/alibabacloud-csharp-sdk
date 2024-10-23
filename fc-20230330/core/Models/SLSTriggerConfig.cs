// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SLSTriggerConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("functionParameter")]
        [Validation(Required=false)]
        public Dictionary<string, string> FunctionParameter { get; set; }

        [NameInMap("jobConfig")]
        [Validation(Required=false)]
        public JobConfig JobConfig { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public SLSTriggerLogConfig LogConfig { get; set; }

        [NameInMap("sourceConfig")]
        [Validation(Required=false)]
        public SourceConfig SourceConfig { get; set; }

    }

}
