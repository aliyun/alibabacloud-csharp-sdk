// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DryRunResult : TeaModel {
        /// <summary>
        /// <para>The exit code. A value of 0 indicates that the validation passed. A value of 1 indicates that the request was rejected by business rules. For specific reasons, see violations. A value of 2 indicates that the request structure cannot be parsed and rule validation cannot be performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("exitCode")]
        [Validation(Required=false)]
        public int? ExitCode { get; set; }

        /// <summary>
        /// <para>The text representation of the result. A value of ok indicates that the validation passed, and rejected indicates that the request was rejected by business rules. This field is empty when the exit code is 2, which means the request structure cannot be parsed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rejected</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The list of violations. Each violation consists of three elements: field, message, and suggestion, which represent the path of the violated field, the violation description, and the remediation suggestion, respectively. This array is empty when the exit code is 0 (passed). All violations are listed when the exit code is 1 (rejected by business rules). The location and cause of the unparseable fields are provided when the exit code is 2 (unparseable request structure).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;schedule.intervalSecs&quot;,&quot;message&quot;:&quot;schedule interval must be a multiple of 15 seconds&quot;,&quot;suggestion&quot;:&quot;must satisfy: 15-86400 seconds and a multiple of 15&quot;}]</para>
        /// </summary>
        [NameInMap("violations")]
        [Validation(Required=false)]
        public List<DryRunViolation> Violations { get; set; }

    }

}
