// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class CreateListenerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>lsn-wi3c0v30ivysrg****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A045E652-D298-5E70-A978-7247135336FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
