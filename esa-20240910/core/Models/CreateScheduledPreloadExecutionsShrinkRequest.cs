// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateScheduledPreloadExecutionsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Executions")]
        [Validation(Required=false)]
        public string ExecutionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateScheduledPreloadExecutions</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
