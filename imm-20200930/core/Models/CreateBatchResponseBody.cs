// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateBatchResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the batch processing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch-4eb9223f-3e88-42d3-a578-3f2852******</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC564A9A-BA5C-4499-A087-D9B9E76E*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
