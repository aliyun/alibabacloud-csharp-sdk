// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskResponseBodyData Data { get; set; }
        public class CreateWmEmbedTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>job:5GfrJYsoaffmCE7Z5bZtjUefzxfd****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
