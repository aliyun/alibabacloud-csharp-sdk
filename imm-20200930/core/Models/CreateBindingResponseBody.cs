// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateBindingResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the binding.</para>
        /// </summary>
        [NameInMap("Binding")]
        [Validation(Required=false)]
        public Binding Binding { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F74C5C9-5AC0-49F9-914D-E01589D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
