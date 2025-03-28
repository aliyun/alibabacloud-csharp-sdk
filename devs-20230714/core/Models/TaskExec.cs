// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TaskExec : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public Context Context { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task-1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("runAfters")]
        [Validation(Required=false)]
        public List<RunAfter> RunAfters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>serverless-runner</para>
        /// </summary>
        [NameInMap("taskTemplate")]
        [Validation(Required=false)]
        public string TaskTemplate { get; set; }

    }

}
