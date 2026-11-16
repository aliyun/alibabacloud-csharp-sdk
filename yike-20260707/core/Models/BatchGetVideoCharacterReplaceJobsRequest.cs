// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class BatchGetVideoCharacterReplaceJobsRequest : TeaModel {
        /// <summary>
        /// <para>The job IDs. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag_83baeea38b534ee1937b8a4acd08****,ag_f7eeed5d5e294dfba4bb347177e1****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

    }

}
