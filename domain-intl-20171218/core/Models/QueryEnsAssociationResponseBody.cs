// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryEnsAssociationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0x0000000000000000000000000000000000000003</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AF7D4DCE-0776-47F2-A9B2-6FB85A87AA60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
