// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DeleteCustomLineResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>520002</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public string LineId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A73F3BD0-B1A8-42A9-A9B6-689BBABC4891</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
