// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoRemakeJobRequest : TeaModel {
        /// <summary>
        /// <para>The task ID returned by SubmitVideoRemakeJob.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
