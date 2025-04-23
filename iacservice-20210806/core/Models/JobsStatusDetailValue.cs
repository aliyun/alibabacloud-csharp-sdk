// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class JobsStatusDetailValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("jobResult")]
        [Validation(Required=false)]
        public string JobResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-06-13 17:11:34</para>
        /// </summary>
        [NameInMap("timeStamps")]
        [Validation(Required=false)]
        public string TimeStamps { get; set; }

    }

}
