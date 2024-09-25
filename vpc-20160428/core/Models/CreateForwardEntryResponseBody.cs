// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateForwardEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fwd-119smw5tkasdf****</para>
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4AEE536-A97A-40EB-9EBE-53A6948A6928</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
