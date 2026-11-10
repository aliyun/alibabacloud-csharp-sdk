// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class JobStatusDetailValue : TeaModel {
        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remarks</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apply complete! Resources: 0 added, 0 changed, 0 destroyed.</para>
        /// </summary>
        [NameInMap("jobResult")]
        [Validation(Required=false)]
        public string JobResult { get; set; }

        /// <summary>
        /// <para>The time when the status is reached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-13 17:11:34</para>
        /// </summary>
        [NameInMap("timeStamps")]
        [Validation(Required=false)]
        public string TimeStamps { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error：Cannot import non-existent remote object</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}
