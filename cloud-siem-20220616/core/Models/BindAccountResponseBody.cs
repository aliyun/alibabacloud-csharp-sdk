// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class BindAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The specific content returned by the Threat Analysis service.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindAccountResponseBodyData Data { get; set; }
        public class BindAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of added account bindings.</para>
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
