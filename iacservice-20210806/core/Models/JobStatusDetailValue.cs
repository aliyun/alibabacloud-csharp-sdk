// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class JobStatusDetailValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("jobResult")]
        [Validation(Required=false)]
        public string JobResult { get; set; }

        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-06-13 17:11:34</para>
        /// </summary>
        [NameInMap("timeStamps")]
        [Validation(Required=false)]
        public string TimeStamps { get; set; }

    }

}
