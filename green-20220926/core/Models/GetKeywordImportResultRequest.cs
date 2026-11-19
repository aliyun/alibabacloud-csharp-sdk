// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetKeywordImportResultRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The task ID. Although this parameter is marked as required:false in the specification, it is actually required. If you do not provide this parameter, the service returns a 400 error. You can obtain the task ID from the TaskId field in the response of the AddKeywordsToLib operation when you import keywords in batches from a file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
