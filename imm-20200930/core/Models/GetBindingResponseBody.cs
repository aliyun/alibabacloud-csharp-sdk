// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetBindingResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the binding.</para>
        /// </summary>
        [NameInMap("Binding")]
        [Validation(Required=false)]
        public Binding Binding { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AEFCD467-C928-4A36-951A-6EB5A592****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
