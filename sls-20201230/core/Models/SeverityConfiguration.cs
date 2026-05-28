// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class SeverityConfiguration : TeaModel {
        /// <summary>
        /// <para>The trigger condition configurations.</para>
        /// </summary>
        [NameInMap("evalCondition")]
        [Validation(Required=false)]
        public ConditionConfiguration EvalCondition { get; set; }

        /// <summary>
        /// <para>The value of the alert severity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public int? Severity { get; set; }

    }

}
