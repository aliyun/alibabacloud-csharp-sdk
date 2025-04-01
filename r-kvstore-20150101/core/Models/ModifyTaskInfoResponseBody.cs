// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if a task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mst.errorcode.success.errormessage</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the failed task. This parameter is returned if a task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0mqaj5hnyofczv****</para>
        /// </summary>
        [NameInMap("ErrorTaskId")]
        [Validation(Required=false)]
        public string ErrorTaskId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2B98499B-E62B-56D4-8D7F-3D6D4DB260F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of completed tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public string SuccessCount { get; set; }

    }

}
