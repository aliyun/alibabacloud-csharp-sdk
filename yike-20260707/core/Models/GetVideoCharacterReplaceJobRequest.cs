// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoCharacterReplaceJobRequest : TeaModel {
        /// <summary>
        /// <para>The task ID, which is returned by SubmitVideoCharacterReplaceJob.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag_83baeea38b534ee1937b8a4acd08****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
