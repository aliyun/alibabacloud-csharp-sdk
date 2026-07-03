// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ModifyBindAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value of the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyBindAccountResponseBodyData Data { get; set; }
        public class ModifyBindAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of account bindings that are modified. A value of 1 indicates that the operation is successful. A value of 0 or less indicates that the operation failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
