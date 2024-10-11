// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class PushColdStartDocumentRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<PushColdStartDocumentRequestBody> Body { get; set; }
        public class PushColdStartDocumentRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("fields")]
            [Validation(Required=false)]
            public object Fields { get; set; }

        }

    }

}
