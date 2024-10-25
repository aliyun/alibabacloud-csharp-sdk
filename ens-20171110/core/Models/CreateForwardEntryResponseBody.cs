// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateForwardEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fwd-5tc07cw14metghn3siv4ak8do</para>
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF6D6FA4-DACA-5822-A981-81006271D263</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
