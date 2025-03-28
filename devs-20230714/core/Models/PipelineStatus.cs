// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineStatus : TeaModel {
        [NameInMap("latestExecError")]
        [Validation(Required=false)]
        public TaskExecError LatestExecError { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

    }

}
