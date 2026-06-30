// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class CreateMultiOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of order IDs.</para>
        /// </summary>
        [NameInMap("OrderIds")]
        [Validation(Required=false)]
        public List<long?> OrderIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>833C4D2C-09C7-5CE6-8159-06758B964970</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
