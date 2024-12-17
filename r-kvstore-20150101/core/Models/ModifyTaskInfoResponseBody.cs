// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mst.errorcode.success.errormessage</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-0mqaj5hnyofczv****</para>
        /// </summary>
        [NameInMap("ErrorTaskId")]
        [Validation(Required=false)]
        public string ErrorTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2B98499B-E62B-56D4-8D7F-3D6D4DB260F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public string SuccessCount { get; set; }

    }

}
