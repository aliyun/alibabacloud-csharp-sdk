// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class MarkOssV2ResultResponseBody : TeaModel {
        [NameInMap("FailureRequestIds")]
        [Validation(Required=false)]
        public List<string> FailureRequestIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessRequestIds")]
        [Validation(Required=false)]
        public List<string> SuccessRequestIds { get; set; }

    }

}
