// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteContextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>897294a7-67a4-4f60-976c-e136edc5f97e</para>
        /// </summary>
        [NameInMap("contextId")]
        [Validation(Required=false)]
        public string ContextId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E5B1D3D4-BB28-5996-8AD2-***********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>deleted</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
