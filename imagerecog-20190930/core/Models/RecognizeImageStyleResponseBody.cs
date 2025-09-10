// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeImageStyleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeImageStyleResponseBodyData Data { get; set; }
        public class RecognizeImageStyleResponseBodyData : TeaModel {
            [NameInMap("Styles")]
            [Validation(Required=false)]
            public List<string> Styles { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66FC3009-9A7A-4D29-8B70-D6EB256EF590</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
