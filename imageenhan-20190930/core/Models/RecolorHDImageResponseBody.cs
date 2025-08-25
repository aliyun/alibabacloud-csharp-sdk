// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RecolorHDImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecolorHDImageResponseBodyData Data { get; set; }
        public class RecolorHDImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<string> ImageList { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9364CEB1-1C39-489F-B6DB-6E65577429F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
