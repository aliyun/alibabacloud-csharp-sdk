// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class UpdateResourcesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateResourcesResponseBodyData Data { get; set; }
        public class UpdateResourcesResponseBodyData : TeaModel {
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
        /// <para>5B2F09BF-CEBD-5A7E-AC01-E7F86169A5E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
