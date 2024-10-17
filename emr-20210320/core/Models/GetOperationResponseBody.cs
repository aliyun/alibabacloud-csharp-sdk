// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetOperationResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation that was performed.</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public Operation Operation { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3A7161-EB7B-172B-8D18-FFB06BA3896A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
