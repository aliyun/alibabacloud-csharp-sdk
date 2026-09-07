// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoDetextJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The video text erasure job ID. You can use this ID to call GetVideoDetextJob to query the job status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vdt_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID, which is used for Tracing Analysis and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-detext-20260820-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
