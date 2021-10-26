// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class LogTriggerConfig : TeaModel {
        /// <summary>
        /// enable
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// functionParameter
        /// </summary>
        [NameInMap("functionParameter")]
        [Validation(Required=false)]
        public Dictionary<string, string> FunctionParameter { get; set; }

        [NameInMap("jobConfig")]
        [Validation(Required=false)]
        public JobConfig JobConfig { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public JobLogConfig LogConfig { get; set; }

        [NameInMap("sourceConfig")]
        [Validation(Required=false)]
        public SourceConfig SourceConfig { get; set; }

    }

}
