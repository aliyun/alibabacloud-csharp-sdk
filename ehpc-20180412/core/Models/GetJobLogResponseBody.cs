// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetJobLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the error logs. The content is encoded in Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2xlZXAgMzA=</para>
        /// </summary>
        [NameInMap("ErrorLog")]
        [Validation(Required=false)]
        public string ErrorLog { get; set; }

        /// <summary>
        /// <para>The ID of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.scheduler****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The content of the output logs. The content is encoded in Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2xlZXAgMzA=</para>
        /// </summary>
        [NameInMap("OutputLog")]
        [Validation(Required=false)]
        public string OutputLog { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B745C159-3155-4B94-95D0-4B73D4D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
