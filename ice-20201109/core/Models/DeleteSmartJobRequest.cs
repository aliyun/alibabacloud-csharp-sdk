// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteSmartJobRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the jobs to delete. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>b48fb04483915d4f2cd8</b></b></b>,<b><b><b>042d5e4db6866f6289d1</b></b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
