// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class MarkOssV2ResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of request IDs for failed operations.</para>
        /// </summary>
        [NameInMap("FailureRequestIds")]
        [Validation(Required=false)]
        public List<string> FailureRequestIds { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. This ID can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of request IDs for successful operations.</para>
        /// </summary>
        [NameInMap("SuccessRequestIds")]
        [Validation(Required=false)]
        public List<string> SuccessRequestIds { get; set; }

    }

}
