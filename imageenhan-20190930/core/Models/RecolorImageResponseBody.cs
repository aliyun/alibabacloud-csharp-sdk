// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RecolorImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecolorImageResponseBodyData Data { get; set; }
        public class RecolorImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<string> ImageList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3A9BFC5E-3F7C-4D9A-9445-908C6D14AB5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
