// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TaskTemplateSpec : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public Context Context { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>build&amp;deploy.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executeCondition")]
        [Validation(Required=false)]
        public Condition ExecuteCondition { get; set; }

        [NameInMap("worker")]
        [Validation(Required=false)]
        public TaskWorker Worker { get; set; }

    }

}
