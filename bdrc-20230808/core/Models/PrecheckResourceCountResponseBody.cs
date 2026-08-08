// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class PrecheckResourceCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PrecheckResourceCountResponseBodyData Data { get; set; }
        public class PrecheckResourceCountResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>t-bp1ewftyzmeg3bl4dtd2</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86DEBAC9-AB6A-59AB-9E5C-A540E579ECC9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
