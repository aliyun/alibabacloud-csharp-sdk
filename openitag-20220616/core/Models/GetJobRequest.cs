// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class GetJobRequest : TeaModel {
        /// <summary>
        /// <para>Task Type. Currently, only DOWNLOWD_MARKRESULT_FLOW is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOWNLOWD_MARKRESULT_FLOW</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

    }

}
