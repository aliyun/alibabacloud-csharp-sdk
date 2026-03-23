// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteApplicationPromptResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>papt-f9lajgw765f4fnrzn1</para>
        /// </summary>
        [NameInMap("PromptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
